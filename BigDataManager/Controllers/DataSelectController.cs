using BigDataManager.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdiyer.WebControls.Mvc;

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
            List<RegionModel> /*结构化数据*/ Stru = jz.Database.SqlQuery<RegionModel>(@"SELECT count(*) AS StructuringCount,person_base.c AS NAME,person_base.ah AS CODE from (SELECT c,ah FROM tpersons WHERE ai = @pid) as person_base GROUP BY person_base.ah", parentid).ToList();
            List<RegionModel> /*非结构化数据*/ NotStru = jz.Database.SqlQuery<RegionModel>("SELECT count(*) AS NotStructuringCount FROM (SELECT person_base.d,person_base.AH FROM tpersons AS person_base WHERE person_base.D <>'' AND person_base.ai =@pid) AS a INNER JOIN businessinfo AS b ON a.d = b.IDNUMBER INNER JOIN materialtakeinfo AS c ON b.CURRAFFAIRID = c.CURR_AFFAIRID WHERE c.SAVEPATH <>'' GROUP BY a.AH;", parentid).ToList();
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
            return View(tmp.ToPagedList(pageIndex,pageSize));
        }
        /// <summary>
        /// 人员详细结构化
        /// </summary>
        /// <returns></returns>
        public ActionResult PopulationDetailStructuring(string pid="") 
        {
            MySqlParameter parentid = new MySqlParameter("pid", pid);
            List<PersonalInfoModel> list = jz.Database.SqlQuery<PersonalInfoModel>("select a.b as Name,a.e as Sex,a.f as Birth from tpersons as a left JOIN businessinfo as b on a.D=b.IDNUMBER LEFT JOIN user_report c on a.D=c.cardid WHERE a.d=@pid", parentid).ToList();
            return View(list);
           
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
