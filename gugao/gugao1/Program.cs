using System;
using gts;
using System.IO;

namespace gugao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
#if falsh
            FileStream F = new FileStream(@"\gugao-board\gugao\gugao1\test.dat",
            FileMode.Open, FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }

            F.Position = 0;

            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.Write("结束！");
            Console.ReadKey();
#endif


#if true
            int rtn;
            short AXIS=1;

            mc.TJogPrm jog;

            //轴的状态
            int sts;
            short count=1;
            uint clock;
            double prfPos, prfVel;

            //打开运动控制器
            rtn = mc.GT_Open(0, 1);
            //Commandhandler("GT_Open", rtn);
            //复位
            rtn = mc.GT_Reset();
            //Commandhandler("GT_Reset", rtn);

            //配置运动控制器
            mc.GT_LoadConfig(@"\gugao-board\gugao\gugao1\test.cfg");
            //Commandhandler("GT_LoadConfig", rtn);
            mc.GT_ClrSts(1, 8);
            //Commandhandler("GT_ClrSts", rtn);

            //将AXIS轴设为Jog模式
            mc.GT_PrfJog(AXIS);
            //Commandhandler("GT_PrfJog", rtn);

            jog.acc = 0.0625;
            jog.dec = 0.0625;
            jog.smooth = 0.5;
            mc.GT_SetJogPrm(AXIS, ref jog);

            // 设置 AXIS 轴的目标速度
            mc.GT_SetVel(AXIS, 100);
            // 启动 AXIS 轴的运动
            mc.GT_Update(1 << (AXIS - 1));

            while(true)
            {
                //读取AXIS轴的状态
                mc.GT_GetSts(AXIS, out sts , count, out clock);

                // 读取AXIS轴的规划位置
                mc.GT_GetPrfPos(AXIS, out prfPos , count, out clock);

                // 读取AXIS轴的规划速度
                mc.GT_GetPrfVel(AXIS, out prfVel, count, out clock);

                Console.WriteLine("sts={sts},prfPos={prfPos},prfVel={prfVel}");
            }
#endif

        }
    }
}

