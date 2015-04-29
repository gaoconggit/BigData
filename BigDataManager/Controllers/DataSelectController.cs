using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigDataManager.Controllers
{
    public class DataSelectController : Controller
    {
        //
        // GET: /DataSelect/
        /// <summary>
        /// 按区域查询
        /// </summary>
        /// <returns></returns>
        public ActionResult AccordingToTheRegion ()
        {
            return View();
        }
        /// <summary>
        /// 按村居查询
        /// </summary>
        /// <returns></returns>
        public ActionResult AccordingToTheVillage() 
        {
            return View();
        }
        /// <summary>
        /// 按居住人口查询
        /// </summary>
        /// <returns></returns>
        public ActionResult AccordingToThePopulation()
        {
            return View();
        }
        /// <summary>
        /// 人员详细结构化
        /// </summary>
        /// <returns></returns>
        public ActionResult PopulationDetailStructuring() 
        {
            return View();
        }
        /// <summary>
        /// 材料详情
        /// </summary>
        /// <returns></returns>
        public ActionResult MaterialDetail()
        {
            return View();
        }

    }
}
