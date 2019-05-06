using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CloudProjectTracking.Models;
using CloudProjectTracking.Models.Entities;

namespace CloudProjectTracking.Controllers
{
    public class TasksController : Controller
    {
        private Model1 db = new Model1();

        // GET: Tasks
        public ActionResult Index()
        {
           

           
            
            return View(db.Tasks.Include(x=>x.Status).ToList());
        }
        public ActionResult ProjectDashboard()
        {

            return View(db.Tasks.Include(x => x.Status).ToList());
        }

        // GET: Tasks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task task = db.Tasks.Include(e => e.Contractor)
                .Include(e => e.Status)
                .ToList().Find(e => e.Id == id);

            if (task == null)
            {
                return HttpNotFound();
            }
            return View(task);
        }

        // GET: Tasks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Task task)
        {
            if (ModelState.IsValid)
            {
                db.Tasks.Add(task);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(task);
        }

        // GET: Tasks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task task = db.Tasks.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            return View(task);
        }

        // POST: Tasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Cost,Start_Date,End_Date")] Task task)
        {
            if (ModelState.IsValid)
            {
                db.Entry(task).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(task);
        }

        // GET: Tasks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task task = db.Tasks.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            return View(task);
        }

        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Task task = db.Tasks.Find(id);
            db.Tasks.Remove(task);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(IEnumerable<HttpPostedFileBase> files)
        {
            foreach (var file in files)
            {
                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                    file.SaveAs(path);
                }
            }
            IEnumerable<HttpPostedFileBase> uploadedFiles = files;
            string[] fileNames = {
                "Drawings",
                "Specs",
            };
            int i = 0;
            foreach (var item in uploadedFiles)
            {
                var doc = new Task_Documents()
                {
                    Data = new byte[item.InputStream.Length],
                    FileName = item.FileName,
                    ContentType = item.ContentType,
                    Document_Name = fileNames[i],
                };
                item.InputStream.Read(doc.Data, 0, doc.Data.Length);
                db.Task_Documents.Add(doc);
                i++;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpPost]
        public FileResult Download(int? id)
        {
            Task_Documents tFile = db.Task_Documents.Find(id);
            byte[] bytes = tFile.Data;
            string fileName = tFile.FileName;
            string contentType = tFile.ContentType;
            return File(bytes, contentType, fileName);
        }

        // GET: Tasks/Create
        public ActionResult CreateRFI(int id)
        {
            return View();
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateRFI(RFI RFI)
        {
            if (ModelState.IsValid)
            {
                db.RFIs.Add(RFI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(RFI);
        }
        




        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
