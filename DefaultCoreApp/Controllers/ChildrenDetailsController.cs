using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DefaultCoreApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DefaultCoreApp.Controllers
{
    public class ChildrenDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Save all the Children Details in Database if record is newely created and Update the children details in database if that records is already exist
        /// </summary>
        /// <param name="objChildrenDetail"></param>
        /// <returns></returns>

        [HttpPost]
        public ActionResult Index(ChildrenDetails objChildrenDetail)
        {
            try
            {
                //if (ModelState.IsValid)
                //{
                    ChildrenDetailsContext db = new ChildrenDetailsContext();

                    if (TempData["ID"] != null)
                    {
                        int ID = Convert.ToInt32(TempData["ID"]);
                        ChildrenDetails objChildrenDetails = db.ChildrenDetails.FirstOrDefault(x => x.Id == ID);
                        if (objChildrenDetails != null)
                        {
                            objChildrenDetails.ChildFirstName = objChildrenDetail.ChildFirstName;
                            objChildrenDetails.ChildLastName = objChildrenDetail.ChildLastName;
                            objChildrenDetails.ChildGender = objChildrenDetail.ChildGender;
                            objChildrenDetails.ChildBirthDate = objChildrenDetail.ChildBirthDate;
                            objChildrenDetails.ChildStatus = objChildrenDetail.ChildStatus;
                            objChildrenDetails.ChildAddress = objChildrenDetail.ChildAddress;
                            objChildrenDetails.ChildType = objChildrenDetail.ChildType;
                            objChildrenDetails.Parent1LastName = objChildrenDetail.Parent1LastName;
                            objChildrenDetails.Parent1FirstName = objChildrenDetail.Parent1FirstName;
                            objChildrenDetails.Parent1Private = objChildrenDetail.Parent1Private;
                            objChildrenDetails.Parent1Gender = objChildrenDetail.Parent1Gender;
                            objChildrenDetails.Parent1ChildRelation = objChildrenDetail.Parent1ChildRelation;
                            objChildrenDetails.Parent1Address = objChildrenDetail.Parent1Address;
                            objChildrenDetails.Parent1Unit = objChildrenDetail.Parent1Unit;
                            objChildrenDetails.Parent1City = objChildrenDetail.Parent1City;
                            objChildrenDetails.Parent1Province = objChildrenDetail.Parent1Province;
                            objChildrenDetails.Parent1PostalCode = objChildrenDetail.Parent1PostalCode;
                            objChildrenDetails.Parent1HomePhone = objChildrenDetail.Parent1HomePhone;

                            objChildrenDetails.Contact1Name = objChildrenDetail.Contact1Name;
                            objChildrenDetails.Contact1Phone = objChildrenDetail.Contact1Phone;
                            objChildrenDetails.Contact1Email = objChildrenDetail.Contact1Email;


                            db.ChildrenDetails.Update(objChildrenDetails);
                            db.SaveChanges();
                            TempData["ID"] = null;
                        }
                    }
                    else
                    {
                        db.ChildrenDetails.Add(objChildrenDetail);
                        db.SaveChanges();
                    }
                    ModelState.Clear();
                    return RedirectToAction("ChildrenLists");
                //}

                //return View(objChildrenDetail);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// This ActionResult is used for populating the data of all Childrens from database and show it on ChildrenLists page and also searched the children details 
        /// based on First Name and Last Name
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public ActionResult ChildrenLists(string searchString)
        {

            try
            {

                IFormFile[] files;
                files = null;
                ViewBag.files = files;

                ChildrenDetailsContext objChildrenDetailsEntities = new ChildrenDetailsContext();

                var data = from item in objChildrenDetailsEntities.ChildrenDetails
                           select item;

                if (!String.IsNullOrEmpty(searchString))
                {
                    data = data.Where(s => s.ChildLastName.ToUpper().Contains(searchString.ToUpper())
                                           || s.ChildFirstName.ToUpper().Contains(searchString.ToUpper()));
                }

                return View(data.ToList());
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Select existing records of children from ChildrenList page to Update in database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            try
            {
                using (ChildrenDetailsContext db = new ChildrenDetailsContext())
                {
                    ChildrenLists model = new ChildrenLists();
                    model.SelectedCustomer = db.ChildrenDetails.Find(id);
                    model.DisplayMode = "ReadOnly";
                    TempData["ID"] = id;

                    return View("Index", model.SelectedCustomer);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Delete existing records of childredn from ChildrenList page and from database as well
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public ActionResult Delete(int id)
        {
            try
            {
                ChildrenDetailsContext db = new ChildrenDetailsContext();
                ChildrenDetails objChildrenDetail = db.ChildrenDetails.Find(id);
                db.ChildrenDetails.Remove(objChildrenDetail);
                db.SaveChanges();
                return RedirectToAction("ChildrenLists");
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Upload Childrens files on local directory folder
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UploadFiles(IFormFile[] files)
        {

            try
            {
                ChildrenDetailsContext db = new ChildrenDetailsContext();

                if (files != null)
                {
                    foreach (var file in files)
                    {
                        // extract only the filename
                        var fileName = Path.GetFileName(file.FileName);

                        // extract the file content to byte array
                        var content = new byte[file.Length];
                        // reads the content from stream
                        //file.InputStream.Read(content, 0, file.ContentLength);
                        file.OpenReadStream();

                        //get file extesion
                        var fileExtension = Path.GetExtension(fileName);
                        //save file name as uniqe
                        var uniqueFileName = Guid.NewGuid().ToString();

                        ChildrenFileUpload objChildrenFileUpload = new ChildrenFileUpload
                        {
                            FileName = uniqueFileName,
                            UploadDate = DateTime.Now,
                            FileContent = content
                        };

                        db.ChildrenFileUpload.Add(objChildrenFileUpload);
                        db.SaveChanges();
                    }
                }

                return RedirectToAction("ChildrenLists");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}