using BigDataManager.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigDataManager.Controllers
{
    public class DataSelectController : Controller
    {
      
        jianzhengEntities jz = new jianzhengEntities();
        //
        // GET: /DataSelect/
        /// <summary>
        /// 按区域查询
        /// </summary>
        /// <returns></returns>
        public ActionResult AccordingToTheRegion ()
        {
            List<RegionModel>  /*结构化数据*/ Stru = jz.Database.SqlQuery<RegionModel>("SELECT count(*) as StructuringCount,a.CNAME as Name,a.`CODE` as Code from  dic_town as a left JOIN tpersons as b ON a.`CODE`=b.AI WHERE a.`CODE`<>0 GROUP BY a.`CODE`;").ToList();

            List<RegionModel> /*非结构化数据*/ NotStru = jz.Database.SqlQuery<RegionModel>("select count(*) as NotStructuringCount from materialtakeinfo as a where SAVEPATH<>'' and TOWNCODE<>0 GROUP BY TOWNCODE;").ToList();
            List<RegionModel> list = new List<RegionModel>();
            for (int i = 0; i < Stru.Count; i++)
            {
                RegionModel r = new RegionModel { Name = Stru[i].Name, StructuringCount = Stru[i].StructuringCount, NotStructuringCount=NotStru[i].NotStructuringCount,Code=Stru[i].Code};
                list.Add(r);
            }
            return View(list);
        }
        /// <summary>
        /// 按村居查询
        /// </summary>
        /// <returns></returns>
        public ActionResult AccordingToTheVillage(int pid=0) 
        {
            
            MySqlParameter parentid=new MySqlParameter("pid",pid);
            List<RegionModel> /*结构化数据*/ Stru = jz.Database.SqlQuery<RegionModel>("select count(*) as StructuringCount,c as Name,ah as Code from tpersons WHERE ai=@pid GROUP BY ah;", parentid).ToList();
            List<RegionModel> /*非结构化数据*/ NotStru = jz.Database.SqlQuery<RegionModel>(" select count(*) as NotStructuringCount from  tpersons as a  INNER JOIN  businessinfo as b on a.d=b.IDNUMBER INNER JOIN materialtakeinfo as c ON b.CURRAFFAIRID=c.CURR_AFFAIRID where a.D<>'' and c.SAVEPATH<>'' and a.ai=@pid GROUP BY a.AH ", parentid).ToList();
            List<RegionModel> list = new List<RegionModel>();
            for (int i = 0; i < Stru.Count; i++)
            {
                RegionModel r = new RegionModel { Name = Stru[i].Name, StructuringCount = Stru[i].StructuringCount, NotStructuringCount = NotStru[i].NotStructuringCount, Code = Stru[i].Code };
                list.Add(r);
            }
            return View(list);
        }
        /// <summary>
        /// 按居住人口查询
        /// </summary>
        /// <returns></returns>
        public ActionResult AccordingToThePopulation(int pid = 124,int pageIndex=1,int pageSize=10)
        {
            MySqlParameter parentid = new MySqlParameter("pid", pid);
            var tmp = jz.Database.SqlQuery<RdtPnModel>("select  b as Name,d as IdCard,aj as IsLocalCity from tpersons as a where ah=@pid", parentid);
            int TotalCount=  tmp.Count();
            List<RdtPnModel> list = tmp.Skip((pageIndex-1)*pageSize).Take(pageSize).ToList();
            ViewData["pid"] = pid;
            ViewData["pageIndex"] = pageIndex;
            ViewData["pageSize"] = pageSize;
            ViewData["TotalCount"] = TotalCount;
            return View(list);
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
