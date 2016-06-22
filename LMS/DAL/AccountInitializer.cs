using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LMS.DAL
{
    public class AccountInitializer : DropCreateDatabaseIfModelChanges<AccountContext>
    {
        protected override void Seed(AccountContext context)
        {
            //用户管理信息表
            var admins = new List<Models.Admin>
            {
                new Models.Admin { AdminName="管理员",AdminAccount="admin",AdminPwd="admin",AdminTel="88888888",AdminIntro="好困"},
                new Models.Admin { AdminName="张三",AdminAccount="zhangsan",AdminPwd="zhangsan",AdminTel="13011111111",AdminIntro="好累"},
                new Models.Admin { AdminName="李四",AdminAccount="lisi",AdminPwd="lisi",AdminTel="13022222222",AdminIntro="好渴"},
                new Models.Admin { AdminName="王五",AdminAccount="wangwu",AdminPwd="wangwu",AdminTel="13033333333",AdminIntro="好苦"},
                new Models.Admin { AdminName="赵六",AdminAccount="zhaoliu",AdminPwd="zhaoliu",AdminTel="13044444444",AdminIntro="好饿"},
                new Models.Admin { AdminName="刘七",AdminAccount="liuqi",AdminPwd="liuqi",AdminTel="13055555555",AdminIntro="好热"}
            };
            admins.ForEach(s => context.Admins.Add(s));
            context.SaveChanges();

            //车辆管理表
            var Cars = new List<Models.Car>
            {
                //INSERT[Car]([CarID],[CarNo],[CarDiver],[CarAddress],[CarType])
                new Models.Car {CarNo="粤T-XX101",CarDiver="阿笨",CarAddress="中山-佛山",CarType="一汽解放CA524" },
                new Models.Car {CarNo="粤T-XX102",CarDiver="阿根",CarAddress="广州-汕头",CarType="二汽东风DFL33" },
                new Models.Car {CarNo="粤T-XX103",CarDiver="阿据",CarAddress="湛江-汕尾",CarType="三菱SEJDB" },
                new Models.Car {CarNo="粤T-XX104",CarDiver="阿葡",CarAddress="韶关-东莞",CarType="跃进CLXYP" },
                new Models.Car {CarNo="粤T-XX105",CarDiver="阿萄",CarAddress="茂名-深圳",CarType="乘龙K38A0" }
            };
            Cars.ForEach(s => context.Cars.Add(s));
            context.SaveChanges();

            ////班次管理表
            //var Class_s = new List<Models.Classs>
            //{
            //    //INSERT[Class]([ClassID],[Start],[End],[CLassTime],[CarID])
            //    new Models.Classs { ClassID=401,Start="中山",End="佛山",ClassTime=DateTime.Parse("2016/5/8 14:50:00"),CarID=501 },
            //    new Models.Classs { ClassID=402,Start="茂名",End="深圳",ClassTime=DateTime.Parse("2016/5/9 12:50:00"),CarID=505 },
            //    new Models.Classs { ClassID=403,Start="韶关",End="东莞",ClassTime=DateTime.Parse("2016/5/8 10:50:00"),CarID=504 },
            //    new Models.Classs { ClassID=404,Start="深圳",End="汕尾",ClassTime=DateTime.Parse("2016/5/8 08:50:00"),CarID=503},
            //    new Models.Classs { ClassID=405,Start="广州",End="汕头",ClassTime=DateTime.Parse("2016/5/8 06:50:00"),CarID=502 }
            //};
            //Class_s.ForEach(s => context.Classss.Add(s));
            //context.SaveChanges();

            //发货人
            //var F_Customers = new List<Models.F_Customer>
            //{
            //    //INSERT[F_Customer]([F_CustoNo],[F_CustoTel],[F_CustoName])
            //    new Models.F_Customer{ F_CustoTel="13611111111",F_CustoName="黄先生" },
            //    new Models.F_Customer{ F_CustoTel="13622222222",F_CustoName="孙先生" },
            //    new Models.F_Customer{ F_CustoTel="13633333333",F_CustoName="罗先生" },
            //    new Models.F_Customer{ F_CustoTel="13644444444",F_CustoName="王先生" },
            //    new Models.F_Customer{ F_CustoTel="13655555555",F_CustoName="张先生" }
            //};
            //F_Customers.ForEach(s => context.F_Customers.Add(s));
            //context.SaveChanges();

            ////路线信息表
            //var Lines = new List<Models.Line>
            //{
            //    //INSERT[line]([LineID],[LineLength],[Start],[Line],[End])
            //    new Models.Line { LineID=701,LineLength=50,Start="中山", Lines="没有",End="佛山" },
            //    new Models.Line { LineID=702,LineLength=120,Start="茂名",Lines="广州",End="深圳" },
            //    new Models.Line { LineID=703,LineLength=200,Start="韶关",Lines="广州",End="东莞" },
            //    new Models.Line { LineID=704,LineLength=120,Start="深圳",Lines="梅州",End="汕尾" },
            //    new Models.Line { LineID=705,LineLength=250,Start="广州",Lines="河源",End="汕头" }
            //};
            //Lines.ForEach(s => context.Lines.Add(s));
            //context.SaveChanges();

            //收货人
            //var S_Customers = new List<Models.S_Customer>
            //{
            //    //INSERT[S_Customer]([S_CustoNo],[S_CustoTel],[S_CustoName])
            //    new Models.S_Customer { S_CustoTel="13548956482",S_CustoName="楚可" },
            //    new Models.S_Customer { S_CustoTel="48954189153",S_CustoName="泥马" },
            //    new Models.S_Customer { S_CustoTel="18945984563",S_CustoName="啊三" },
            //    new Models.S_Customer { S_CustoTel="48956845951",S_CustoName="阿不" },
            //    new Models.S_Customer { S_CustoTel="48945674263",S_CustoName="鸡汁" }
            //};
            //S_Customers.ForEach(s => context.S_Customers.Add(s));
            //context.SaveChanges();

            ////订单管理表
            //var Orders = new List<Models.Order>
            //{
            //   //INSERT[Order](OrderID,CarID,ClassID,OrderTime,[Address],[OrderNum],OrderMoney,S_CustoNo,S_CustoName,F_CustoNo,F_CustoName,GoodsName,Start,[End],[Path],AdminNo,LineID)
            //   new Models.Order {OrderID=601,CarID=501,ClassID=401,OrderTime=DateTime.Parse("2015-4-10"),Address="广东省佛山市",OrderNum=15,OrderMoney=1510,S_CustoNo=301,S_CustoName="楚可",F_CustoNo=201,F_CustoName="黄先生",GoodsName="饮料",Start="中山",End="佛山",Path="中山-佛山",AdminNo=101,LineID=701 },
            //   new Models.Order {OrderID=602,CarID=502,ClassID=402,OrderTime=DateTime.Parse("2015-4-10"),Address="广东省汕头市",OrderNum=20,OrderMoney=152,S_CustoNo=302,S_CustoName="泥马",F_CustoNo=202,F_CustoName="孙先生",GoodsName="医药用品",Start="广州",End="汕头",Path="广州-汕头",AdminNo=102,LineID=702 },
            //   new Models.Order {OrderID=603,CarID=503,ClassID=403,OrderTime=DateTime.Parse("2015-4-10"),Address="广东省汕尾市",OrderNum=156,OrderMoney=154,S_CustoNo=303,S_CustoName="啊三",F_CustoNo=203,F_CustoName="罗先生",GoodsName="家用电器",Start="湛江",End="汕尾",Path="湛江-汕尾",AdminNo=103,LineID=703 },
            //   new Models.Order {OrderID=604,CarID=504,ClassID=404,OrderTime=DateTime.Parse("2015-4-10"),Address="广东省东莞市",OrderNum=84,OrderMoney=156,S_CustoNo=304,S_CustoName="阿不",F_CustoNo=204,F_CustoName="王先生",GoodsName="食品",Start="韶关",End="东莞",Path="韶关-东莞",AdminNo=104,LineID=704 },
            //   new Models.Order {OrderID=605,CarID=505,ClassID=405,OrderTime=DateTime.Parse("2015-4-10"),Address="广东省深圳市",OrderNum=51,OrderMoney=156,S_CustoNo=305,S_CustoName="鸡汁",F_CustoNo=205,F_CustoName="张先生",GoodsName="服饰",Start="茂名",End="深圳",Path="茂名-深圳",AdminNo=105,LineID=705 }
            //};
            //Orders.ForEach(s => context.Orders.Add(s));
            //context.SaveChanges();
        }
    }
}
