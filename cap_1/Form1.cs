using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gts;


namespace cap_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Commandhandler(string cmd,short rtn)
        {
            if(rtn != 0)
            {
                MessageBox.Show(cmd + " = " + rtn.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            short rtn;
            //打开运动控制器
            rtn = mc.GT_Open(0, 1);
            Commandhandler("gt_open", rtn);
            //复位
            rtn = mc.GT_Reset();
            Commandhandler("GT_Reset", rtn);

            //配置定时器
            timer1.Interval = 100;
            timer1.Start();

#if false
            short rtn;
            //int rtn;
            short AXIS = 1;

            mc.TJogPrm jog;

            //轴的状态
            int sts;
            short count = 1;
            uint clock;
            double prfPos, prfVel;

            //打开运动控制器
            rtn = mc.GT_Open(0, 1);
            //Commandhandler("GT_Open", rtn);
            //复位
            rtn = mc.GT_Reset();
            //Commandhandler("GT_Reset", rtn);

            //配置运动控制器
            mc.GT_LoadConfig(@"F:\C#\temp1\cap_1\cap_1\test1.cfg");
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
            mc.GT_SetVel(AXIS, 500);
            // 启动 AXIS 轴的运动
            mc.GT_Update(1 << (AXIS - 1));

#endif
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            short rtn;
            //关闭限位和报警
            rtn = mc.GT_AlarmOff(1);
            rtn = mc.GT_LmtsOff(1,-1);
            //清除状态
            rtn = mc.GT_ClrSts(1, 1);
            //使能轴
            rtn = mc.GT_AxisOn(1);

            //位置清零
            rtn = mc.GT_ZeroPos(1,1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            short rtn;
            int sts;
            uint clk;
            double prfPos;
            rtn = mc.GT_GetSts(1,out sts,1,out clk);

            //取出规划的位置
            rtn = mc.GT_GetPrfPos(1,out prfPos,1,out clk);
            //将数字转变为字符串
            lbl_PrfPos.Text = Convert.ToInt32(prfPos).ToString();
        }

        private void btn_Trap_Click(object sender, EventArgs e)
        {
            short rtn;
            uint clk;
            double prfPos;

            //运动速度等显示
            double vel, acc, dec;
            int pos;
            vel = Convert.ToDouble(tb_Vel.Text);
            acc = Convert.ToDouble(tb_Acc.Text);
            dec = Convert.ToDouble(tb_Dec.Text);
            pos = Convert.ToInt32(tb_Pos.Text);



            mc.TTrapPrm trap;
            //设置指定轴为点位运动模式
            rtn = mc.GT_PrfTrap(1);
            //读取点位运动模式下的运动参数
            rtn = mc.GT_GetTrapPrm(1,out trap);
            trap.acc = acc;   //回原点运动的加速度
            trap.dec = dec;  //回原点运动的减速度
            trap.smoothTime = 20;  //回原点的平滑时间
            //设置点位运动模式下的运动参数
            rtn = mc.GT_SetTrapPrm(1, ref trap);

            //设置速度
            rtn = mc.GT_SetVel(1, vel);
            //取出规划的位置
            rtn = mc.GT_GetPrfPos(1, out prfPos, 1, out clk);
            //设置到达的位置
            rtn = mc.GT_SetPos(1, pos);
            //启动电机
            rtn = mc.GT_Update(1 << (1 - 1));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_PrfPos_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_Pos_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Dec_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            short rtn;
            rtn = mc.GT_Stop(1<<(1-1),0);  //后边的0表示，减速度停；如果给1，表示急停
        }
    }
}
 