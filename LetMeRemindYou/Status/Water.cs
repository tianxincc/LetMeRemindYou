using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetMeRemindYou.Status
{
    /// <summary>
    /// 关于喝水的定时任务
    /// 
    /// 水是维持生命最基础的营养元素，
    /// 因此喝水非常重要。根据《中国居民膳食指南》，
    /// 成年人每日所需饮水量应该在1200-1500毫升，
    /// 在一天之中需要喝多次水，大概是8杯水。
    /// </summary>
    public static class Water
    {
        /// <summary>
        /// 1、第一杯水：起床后大概半小时左右喝，可以喝一杯温开水，
        ///     有利于加速促进肠道与血管内废物排出，提高身体的新陈代谢能力，同时补充晚上消耗的水分；
        /// 2、第二杯水：在吃完早餐后半小时左右喝，可以促进肠胃蠕动；
        /// 3、第三杯水：在中午十点左右喝，可以清醒头脑，缓解疲劳；
        /// 4、第四杯水：在午饭前半小时喝，可以补充人体需求的水分，帮助消化；
        /// 5、第五杯水：在午睡后喝，可以及时补充水分，有利于缓解疲劳，使身体保持良好的精神状态；
        /// 6、第六杯水：在下午三点左右喝，可以缓解学习或者工作带来的困倦，同时补充水分；
        /// 7、第七杯水：在下午五点半左右喝，可以缓解饥饿，同时可以避免暴饮暴食；
        /// 8、第八杯水：在睡觉前一个小时左右喝，可以保证夜间水分的补充。
        ///     如果夜间缺水会影响机体排泄毒素的能力，且不利于睡眠质量的保证。
        ///
        /// ps:
        /// 喝水并没有固定的时间，只要有渴觉就应该及时饮水。
        /// 适量的喝水很重要，对人体有很好的帮助，但长期大量喝水会增加肾脏的负担，还有可能影响食欲，
        /// 造成人体营养不足，甚至水中毒，因此为保持身体健康，饮水应多次少量饮用。
        /// 平时要注意身体对水的需求，在合适的时间及时补充水分。
        /// </summary>

        /// <summary>
        ///   早上上班的第一杯水  PS：记得提醒每天吃早饭
        /// </summary>
        public const string OneWaterTime = "9:00:00";
        public const string OneWaterMessage = "上午好呀。每天记得吃早饭呢？在工作开始前先喝杯水吧，这样才能活力满满哟。";

        /// <summary>
        ///    第二杯水  可以清醒头脑，缓解疲劳；
        /// </summary>
        public const string TwoWaterTime = "10:30:00";
        public const string TwoWaterMessage = "工作辛苦啦，喝杯水吧。清醒头脑，缓解疲劳！";

        /// <summary>
        /// 饭前半小时 可以补充人体需求的水分，帮助消化；
        /// </summary>
        public const string ThreeWaterTime = "11:30:00";
        public const string ThreeWaterMessage = "饿了没有呀，马上就可以吃饭啦。现在喝水可以帮助消化哦~~";

        /// <summary>
        ///  午休结束 补充水分，有利于缓解疲劳，使身体保持良好的精神状态；
        /// </summary>
        public const string FourWaterTime = "14:00:00";
        public const string FourWaterMessage = "午休有没有好好休息呀？下午开始啦,喝点水吧。这样身体才能保持良好的精神状态呀！";

        /// <summary>
        /// 缓解学习或者工作带来的困倦，同时补充水分；
        /// </summary>
        public const string FiveWaterTime = "16:00:00";
        public const string FiveWaterMessage = "灵感马上就来了~  润润嗓子，休息一下吧。";

        /// <summary>
        ///  可以缓解饥饿，同时可以避免暴饮暴食  PS: 提醒下班，记得打卡
        /// </summary>
        public const string SixWaterTime = "17:30:00"; 
        public const string SixWaterMessage = "要下班啦，今天工作辛苦啦！别忘记打卡哟";


        public static string CommonWaterName = "提示消息";
    }
}
