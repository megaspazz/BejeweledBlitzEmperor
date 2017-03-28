using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejeweledBlitzEmperor
{
    static class GemParser_FAIL
    {
        private static Dictionary<Signature, GemColor> _map = new Dictionary<Signature, GemColor>();

        public static readonly int TOLERANCE = 2;

        // HYPERCUBE SET
        //private static HashSet<Signature> _set = new HashSet<Signature>();
        private static void AddSignature(Signature sig, GemColor gem)
        {
            // HYPERCUBE HELPER
            //if (gem == Gem.Hypercube)
            //{
            //    _set.Add(sig);
            //    return;
            //}

            // This will throw an exception if we attempt to add duplicates.
            _map.Add(sig, gem);

            // Add colors surrounding the color
            // Throw an exception when attempting to add same color.
            //for (int dr = -TOLERANCE; dr <= TOLERANCE; ++dr)
            //{
            //    for (int dg = -TOLERANCE; dg <= TOLERANCE; ++dg)
            //    {
            //        for (int db = -TOLERANCE; db <= TOLERANCE; ++db)
            //        {

            //        }
            //    }
            //}

            //_map[sig] = gem;
        }

        private static void AddSignature(int[] arr, GemColor gem)
        {
            AddSignature(new Signature(arr), gem);
        }

        static GemParser_FAIL()
        {
            #region Red

            // Basic RED
            AddSignature(new int[] { 16654334, 16655102, 16654846, 14685152, 16653566, 16587773, 16456699, 16325369 }, GemColor.Red);

            // Fire RED
            AddSignature(new int[] { 16720383, 16721151, 16720895, 14751201, 16719615, 16653822, 16522748, 16391418 }, GemColor.Red);

            // Glowing RED
            AddSignature(new int[] { 16747007, 16747775, 16737279, 16736255, 16728575, 16728319, 16728319, 16728063 }, GemColor.Red);
            AddSignature(new int[] { 16741887, 16740863, 16739327, 16737791, 16731135, 16730879, 16733695, 16733439 }, GemColor.Red);
            AddSignature(new int[] { 16735231, 16733439, 16738815, 16735743, 16744703, 16744703, 16745727, 16744703 }, GemColor.Red);
            AddSignature(new int[] { 16729599, 16728319, 16735999, 16732159, 16749055, 16748031, 16742143, 16741119 }, GemColor.Red);
            AddSignature(new int[] { 16725759, 16725759, 16732159, 16202999, 16743935, 16742399, 16738303, 16737791 }, GemColor.Red);
            AddSignature(new int[] { 16723711, 16724479, 16728063, 15477740, 16739583, 16738815, 16737791, 16737535 }, GemColor.Red);
            AddSignature(new int[] { 16722431, 16723199, 16724735, 14950628, 16738303, 16738047, 16737791, 16737535 }, GemColor.Red);
            AddSignature(new int[] { 16721151, 16721919, 16722687, 14687200, 16738047, 16737791, 16737535, 16736767 }, GemColor.Red);
            AddSignature(new int[] { 16721407, 16722943, 16524796, 14554846, 16737791, 16737279, 16737023, 16736767 }, GemColor.Red);
            AddSignature(new int[] { 16734975, 16739071, 16656638, 14949860, 16733439, 16733183, 16732927, 16732415 }, GemColor.Red);
            AddSignature(new int[] { 16743167, 16747775, 16726783, 16069621, 16735487, 16735231, 16737023, 16737023 }, GemColor.Red);
            AddSignature(new int[] { 16747519, 16750591, 16732159, 16731135, 16748543, 16748287, 16749055, 16747775 }, GemColor.Red);
            AddSignature(new int[] { 16747007, 16747775, 16737279, 16736255, 16752895, 16751615, 16745983, 16744703 }, GemColor.Red);
            AddSignature(new int[] { 16741887, 16740863, 16739327, 16737791, 16747263, 16745727, 16742143, 16741119 }, GemColor.Red);
            AddSignature(new int[] { 16735231, 16733439, 16738815, 16735743, 16742911, 16742143, 16741119, 16740863 }, GemColor.Red);
            AddSignature(new int[] { 16729343, 16728319, 16735999, 16732159, 16741119, 16740863, 16740351, 16740095 }, GemColor.Red);
            AddSignature(new int[] { 16724991, 16724991, 16732159, 16202743, 16740607, 16740351, 16739839, 16739583 }, GemColor.Red);
            AddSignature(new int[] { 16723967, 16725503, 16727807, 15411947, 16739839, 16739327, 16739071, 16738559 }, GemColor.Red);
            AddSignature(new int[] { 16728063, 16731391, 16724479, 14950628, 16737279, 16736767, 16736511, 16736255 }, GemColor.Red);
            AddSignature(new int[] { 16736255, 16740607, 16724479, 15214056, 16734719, 16734463, 16734207, 16733695 }, GemColor.Red);
            AddSignature(new int[] { 16743935, 16748287, 16727807, 16201463, 16732415, 16732159, 16732159, 16731903 }, GemColor.Red);
            AddSignature(new int[] { 16748031, 16750847, 16732671, 16731903, 16730367, 16729855, 16729855, 16729599 }, GemColor.Red);
            AddSignature(new int[] { 16726271, 16729343, 16393210, 14489053, 16735487, 16734975, 16734975, 16734463 }, GemColor.Red);

            // x2 RED
            AddSignature(new int[] { 16777215, 15277801, 16777215, 15658734, 16060917, 16716543, 16519676, 16388602 }, GemColor.Red);

            // x3 RED
            AddSignature(new int[] { 16777215, 7212654, 16777215, 14540253, 16060917, 14487517, 16519676, 15470828 }, GemColor.Red);

            // x4 RED
            AddSignature(new int[] { 16777215, 16777215, 16777215, 3474229, 10160795, 5383506, 7735414, 11184810 }, GemColor.Red);

            // x5 RED
            AddSignature(new int[] { 14736864, 16777215, 14540253, 12303291, 12586432, 13373132, 14684128, 15339754 }, GemColor.Red);

            // x6 RED
            AddSignature(new int[] { 16777215, 14540253, 16777215, 11184810, 5768792, 16777215, 5834329, 16777215 }, GemColor.Red);

            #endregion

            #region Green

            // Basic GREEN
            AddSignature(new int[] { 4652614, 7536242, 971790, 256003, 5570132, 5897817, 1091344, 1090576 }, GemColor.Green);

            // Fire GREEN
            AddSignature(new int[] { 4783944, 7667572, 1103120, 387333, 5701462, 6029147, 1222674, 1221906 }, GemColor.Green);

            // Glowing GREEN
            AddSignature(new int[] { 7470961, 9830293, 4390722, 3735352, 10616737, 11009959, 6422369, 6291295 }, GemColor.Green);
            AddSignature(new int[] { 6291295, 8781701, 3735352, 2948908, 11599792, 11796403, 5766999, 5569364 }, GemColor.Green);
            AddSignature(new int[] { 5570388, 8257405, 2947884, 1965853, 10551200, 10551200, 4977227, 4976203 }, GemColor.Green);
            AddSignature(new int[] { 5242703, 8060794, 2157344, 1243154, 9633682, 9830293, 4911178, 4844873 }, GemColor.Green);
            AddSignature(new int[] { 4980555, 7798646, 1564183, 716042, 9371534, 9699219, 4845641, 4844873 }, GemColor.Green);
            AddSignature(new int[] { 4783944, 7602035, 1234450, 452614, 9305997, 9633682, 4779848, 4778568 }, GemColor.Green);
            AddSignature(new int[] { 4849481, 7798646, 1036559, 320260, 9305997, 9568145, 4713799, 4713031 }, GemColor.Green);
            AddSignature(new int[] { 5832536, 9109386, 904973, 254467, 8847238, 9109386, 4318529, 4251968 }, GemColor.Green);
            AddSignature(new int[] { 7667572, 11206570, 1168401, 715274, 8454016, 8781701, 3923259, 3922235 }, GemColor.Green);
            AddSignature(new int[] { 9305997, 12844995, 2156064, 1834779, 8716164, 9043849, 4517188, 4516676 }, GemColor.Green);
            AddSignature(new int[] { 10092441, 13303754, 3275569, 3014445, 11468718, 11861940, 7208813, 7012202 }, GemColor.Green);
            AddSignature(new int[] { 9830293, 12648384, 4128574, 3931963, 12386236, 12582847, 6553443, 6422369 }, GemColor.Green);
            AddSignature(new int[] { 8716164, 11206570, 4456259, 4128574, 11272107, 11337644, 5766999, 5700438 }, GemColor.Green);
            AddSignature(new int[] { 7470961, 9830293, 4390722, 3735352, 10354589, 10551200, 5569876, 5569108 }, GemColor.Green);
            AddSignature(new int[] { 6291295, 8716164, 3735352, 2948908, 10026904, 10289052, 5438034, 5437266 }, GemColor.Green);
            AddSignature(new int[] { 5439314, 8126331, 2947884, 1965853, 9830293, 10157978, 5306448, 5240143 }, GemColor.Green);
            AddSignature(new int[] { 5308240, 8257405, 2091551, 1177361, 9764756, 10026904, 5174606, 5108045 }, GemColor.Green);
            AddSignature(new int[] { 6160221, 9437071, 1498390, 716042, 9174923, 9437071, 4647750, 4581445 }, GemColor.Green);
            AddSignature(new int[] { 7864183, 11403181, 1629464, 979470, 8650627, 8978312, 4121150, 4120126 }, GemColor.Green);
            AddSignature(new int[] { 9371534, 12910532, 2288162, 1965853, 8126331, 8454016, 3594806, 3594038 }, GemColor.Green);
            AddSignature(new int[] { 10092441, 13369291, 3341618, 3079982, 7733109, 8060794, 3264817, 3198512 }, GemColor.Green);
            AddSignature(new int[] { 9830293, 12648384, 4128574, 3931963, 7339887, 7667572, 2870059, 2803754 }, GemColor.Green);
            AddSignature(new int[] { 8716164, 11206570, 4456259, 4128574, 7733109, 8060794, 3792953, 3792185 }, GemColor.Green);

            // x2 GREEN
            AddSignature(new int[] { 16777215, 246531, 16777215, 15658734, 48128, 50176, 49664, 49408 }, GemColor.Green);

            // x3 GREEN
            AddSignature(new int[] { 16777215, 89089, 16777215, 14540253, 48128, 43264, 49664, 46592 }, GemColor.Green);

            // x4 GREEN
            AddSignature(new int[] { 16777215, 16777215, 16777215, 10496, 30464, 2246434, 23296, 11184810 }, GemColor.Green);

            // x5 GREEN
            AddSignature(new int[] { 14541021, 16777215, 14540253, 12303291, 37632, 39936, 44288, 46080 }, GemColor.Green);

            // x6 GREEN
            AddSignature(new int[] { 16777215, 14540253, 16777215, 11184810, 17408, 16777215, 17664, 16777215 }, GemColor.Green);

            // x7 GREEN
            AddSignature(new int[] { 16777215, 170498, 16777215, 16777215, 46592, 50176, 49408, 50432 }, GemColor.Green);

            #endregion

            #region Blue

            // Basic BLUE
            AddSignature(new int[] { 1670681, 12544, 611593, 40448, 1213970, 1213714, 1149969, 1084176 }, GemColor.Blue);

            // Fire BLUE
            AddSignature(new int[] { 1867804, 275460, 1597464, 1090576, 1410837, 1410581, 1412629, 1346836 }, GemColor.Blue);

            // Glowing BLUE
            AddSignature(new int[] { 2263330, 736779, 1730330, 1089296, 5230415, 5098829, 4901962, 4770632 }, GemColor.Blue);
            AddSignature(new int[] { 1999902, 473351, 1137169, 562184, 4966987, 4966987, 4836425, 4770632 }, GemColor.Blue);
            AddSignature(new int[] { 1802011, 275460, 807436, 298756, 4901194, 4901194, 4770632, 4704327 }, GemColor.Blue);
            AddSignature(new int[] { 1867804, 473095, 609545, 166402, 4900938, 4835145, 4704583, 4638790 }, GemColor.Blue);
            AddSignature(new int[] { 2855723, 1790235, 477959, 100609, 4439875, 4374082, 4309313, 4177727 }, GemColor.Blue);
            AddSignature(new int[] { 4699463, 3897147, 741387, 561416, 4044605, 4044605, 3914043, 3847994 }, GemColor.Blue);
            AddSignature(new int[] { 6346080, 5544276, 1729050, 1681177, 4308801, 4308801, 4507972, 4442435 }, GemColor.Blue);
            AddSignature(new int[] { 7136876, 6005851, 2848555, 2866987, 7074411, 7139948, 7207021, 6943593 }, GemColor.Blue);
            AddSignature(new int[] { 6874216, 5347665, 3705656, 3789625, 7995257, 7864183, 6548579, 6350688 }, GemColor.Blue);
            AddSignature(new int[] { 5754967, 3898939, 4035389, 3987772, 6876520, 6613092, 5758295, 5626197 }, GemColor.Blue);
            AddSignature(new int[] { 4503108, 2515238, 3969340, 3592502, 5954650, 5823064, 5560660, 5494867 }, GemColor.Blue);
            AddSignature(new int[] { 3317554, 1395989, 3311154, 2802474, 5625173, 5559636, 5428818, 5363025 }, GemColor.Blue);
            AddSignature(new int[] { 2461221, 802828, 2520870, 1814299, 5428050, 5428050, 5297232, 5165902 }, GemColor.Blue);
            AddSignature(new int[] { 2329123, 934414, 1664537, 1023503, 5361745, 5295952, 5165390, 5033804 }, GemColor.Blue);
            AddSignature(new int[] { 3185200, 2119968, 1071376, 562184, 4769352, 4703559, 4638534, 4507204 }, GemColor.Blue);
            AddSignature(new int[] { 4897354, 4095294, 1202450, 825612, 4242496, 4242496, 4111934, 4045885 }, GemColor.Blue);
            AddSignature(new int[] { 6412385, 5610325, 1861148, 1813019, 3715896, 3715896, 3585590, 3519797 }, GemColor.Blue);
            AddSignature(new int[] { 7137388, 6071644, 2914604, 2933292, 3320626, 3320370, 3255601, 3124271 }, GemColor.Blue);
            AddSignature(new int[] { 6874216, 5347665, 3705656, 3789625, 2925612, 2925612, 2860843, 2729513 }, GemColor.Blue);
            AddSignature(new int[] { 5754967, 3898939, 4035389, 3987772, 3321394, 3321394, 3783737, 3717944 }, GemColor.Blue);
            AddSignature(new int[] { 4503108, 2515238, 3969340, 3592502, 6218590, 6284383, 6417249, 6219614 }, GemColor.Blue);
            AddSignature(new int[] { 2593063, 934670, 2520870, 1814555, 6152285, 5823320, 4968011, 4901962 }, GemColor.Blue);
            AddSignature(new int[] { 3317810, 1461526, 3311154, 2802474, 7205997, 7074155, 5758295, 5495123 }, GemColor.Blue);

            // x2 BLUE
            AddSignature(new int[] { 16777215, 3511605, 16777215, 15658734, 2790954, 2923820, 2857771, 2857259 }, GemColor.Blue);

            // x3 BLUE
            AddSignature(new int[] { 16777215, 1656601, 16777215, 14540253, 2790954, 2525222, 2857771, 2658600 }, GemColor.Blue);

            // x4 BLUE
            AddSignature(new int[] { 16777215, 16777215, 16777215, 598025, 1728282, 2768938, 1329172, 11184810 }, GemColor.Blue);

            // x5 BLUE
            AddSignature(new int[] { 14540765, 16777215, 14540253, 12303291, 2192929, 2325795, 2525478, 2658344 }, GemColor.Blue);

            // x6 BLUE
            AddSignature(new int[] { 16777215, 14540253, 16777215, 11184810, 996879, 16777215, 997135, 16777215 }, GemColor.Blue);

            // x7 BLUE
            AddSignature(new int[] { 16777215, 2782762, 16777215, 16777215, 2724393, 2923820, 2857259, 2923820 }, GemColor.Blue);

            #endregion

            #region Yellow

            // Basic YELLOW
            AddSignature(new int[] { 16695550, 16711422, 16711422, 14388699, 16710654, 16710398, 16709374, 16709118 }, GemColor.Yellow);

            // Coin YELLOW
            AddSignature(new int[] { 10316445, 16776191, 16117749, 16777215, 16513275, 13149128, 15852785, 13939924 }, GemColor.Yellow);

            // Fire YELLOW
            AddSignature(new int[] { 16761599, 16777215, 16777215, 14520797, 16776447, 16776191, 16775167, 16774911 }, GemColor.Yellow);

            // Glowing YELLOW
            AddSignature(new int[] { 16632573, 16777215, 15001572, 12944069, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16772351, 16777215, 15265000, 13404876, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16777215, 16777215, 16252663, 14524637, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16777215, 16777215, 16777215, 15710447, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16777215, 16777215, 16777215, 16633085, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16777215, 16777215, 16777215, 16765695, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16772607, 16777215, 16777215, 16435962, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16766719, 16711678, 16777215, 15645934, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16238071, 16121077, 16777215, 14657759, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16105973, 16252663, 16187382, 13866963, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16765439, 16777215, 15594989, 13405644, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16773631, 16777215, 15726063, 13669072, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16777215, 16777215, 16383993, 14656479, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16777215, 16777215, 16777215, 15776752, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16766975, 16777215, 16777215, 15645934, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16369913, 16252919, 16777215, 14658015, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 16040180, 16055028, 16252919, 13932756, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 15776752, 15791600, 15660782, 13405644, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);
            AddSignature(new int[] { 15578861, 15593709, 15331049, 13142216, 16777215, 16777215, 16777215, 16777215 }, GemColor.Yellow);

            // x2 YELLOW
            AddSignature(new int[] { 16777215, 15328745, 16777215, 15658734, 15657710, 16315640, 16118261, 15986675 }, GemColor.Yellow);

            // x3 YELLOW
            AddSignature(new int[] { 16777215, 7236718, 16777215, 14540253, 15657710, 14144471, 16118261, 15065573 }, GemColor.Yellow);

            // x4 YELLOW
            AddSignature(new int[] { 16777215, 16777215, 16777215, 3420980, 9933975, 5328977, 7565683, 11184810 }, GemColor.Yellow);

            // x5 YELLOW
            AddSignature(new int[] { 14737632, 16777215, 14540253, 12303291, 12236730, 13026246, 14276313, 14933987 }, GemColor.Yellow);

            // x6 YELLOW
            AddSignature(new int[] { 16777215, 14540253, 16777215, 11184810, 5657686, 16777215, 5723479, 16777215 }, GemColor.Yellow);

            // x7 YELLOW
            AddSignature(new int[] { 16777215, 12105144, 16777215, 16777215, 15197159, 16315640, 15986675, 16315640 }, GemColor.Yellow);

            #endregion

            #region Purple

            // Basic PURPLE
            AddSignature(new int[] { 10027161, 16694782, 16061941, 14356187, 16126198, 15994612, 15798257, 15667183 }, GemColor.Purple);

            // Fire PURPLE
            AddSignature(new int[] { 10490528, 16761599, 16129526, 14423772, 16193783, 16062197, 15865330, 15734256 }, GemColor.Purple);

            // Glowing PURPLE
            AddSignature(new int[] { 11616689, 16772351, 15344874, 13836243, 16731135, 16730623, 16730623, 16730367 }, GemColor.Purple);
            AddSignature(new int[] { 13131720, 16777215, 16003572, 14823650, 16728831, 16728319, 16728575, 16728575 }, GemColor.Purple);
            AddSignature(new int[] { 13856723, 16777215, 16729343, 15943923, 16530172, 16463867, 16529660, 16333049 }, GemColor.Purple);
            AddSignature(new int[] { 13593551, 16777215, 16733951, 16734719, 16135158, 16069109, 16134902, 15938291 }, GemColor.Purple);
            AddSignature(new int[] { 12474302, 16772607, 16735999, 16736255, 16530940, 16464891, 16730111, 16730111 }, GemColor.Purple);
            AddSignature(new int[] { 11222443, 16306424, 16735487, 16603133, 16741119, 16740863, 16742143, 16741375 }, GemColor.Purple);
            AddSignature(new int[] { 10037145, 15252712, 16732671, 15813105, 16745471, 16744191, 16738559, 16737791 }, GemColor.Purple);
            AddSignature(new int[] { 9312398, 14725856, 16663294, 14825186, 16740351, 16738559, 16734719, 16734463 }, GemColor.Purple);
            AddSignature(new int[] { 8982665, 14527965, 15872754, 14099927, 16735999, 16734975, 16734207, 16734207 }, GemColor.Purple);
            AddSignature(new int[] { 8521346, 14066646, 14949860, 13309387, 16734463, 16733951, 16733951, 16733439 }, GemColor.Purple);
            AddSignature(new int[] { 8587139, 14264281, 14751969, 13177033, 16734207, 16733439, 16733439, 16733439 }, GemColor.Purple);
            AddSignature(new int[] { 9575058, 15581421, 14620383, 13111240, 16731903, 16731135, 16731391, 16731135 }, GemColor.Purple);
            AddSignature(new int[] { 11418798, 16770815, 14883811, 13572047, 16729855, 16729343, 16729343, 16729087 }, GemColor.Purple);
            AddSignature(new int[] { 13065415, 16777215, 15871474, 14691808, 16731903, 16731391, 16733439, 16733695 }, GemColor.Purple);
            AddSignature(new int[] { 13856211, 16777215, 16728831, 15877618, 16744959, 16744447, 16745471, 16744447 }, GemColor.Purple);
            AddSignature(new int[] { 13593551, 16777215, 16733951, 16734719, 16749311, 16747775, 16742399, 16741375 }, GemColor.Purple);
            AddSignature(new int[] { 12474302, 16772607, 16735999, 16736255, 16743679, 16741887, 16738559, 16737791 }, GemColor.Purple);
            AddSignature(new int[] { 11222443, 16306424, 16735487, 16603133, 16739327, 16738303, 16737535, 16737535 }, GemColor.Purple);
            AddSignature(new int[] { 10036889, 15187175, 16732671, 15813105, 16737535, 16737023, 16736767, 16736767 }, GemColor.Purple);
            AddSignature(new int[] { 9180556, 14594014, 16663294, 14824930, 16737023, 16736511, 16736255, 16736255 }, GemColor.Purple);
            AddSignature(new int[] { 9048458, 14725600, 15806961, 14034134, 16736255, 16735487, 16735487, 16735231 }, GemColor.Purple);
            AddSignature(new int[] { 9904535, 15911154, 15213800, 13572815, 16733695, 16732927, 16732927, 16732927 }, GemColor.Purple);

            // x2 PURPLE
            AddSignature(new int[] { 16777215, 13377484, 16777215, 15658734, 13898452, 14488541, 14291674, 14160600 }, GemColor.Purple);

            // x4 PURPLE
            AddSignature(new int[] { 16777215, 16777215, 16777215, 3015726, 8784774, 4990284, 6686822, 11184810 }, GemColor.Purple);

            // x6 PURPLE
            AddSignature(new int[] { 16777215, 14540253, 16777215, 11184810, 4982348, 16777215, 5047885, 16777215 }, GemColor.Purple);

            #endregion

            #region Orange

            // Basic ORANGE
            AddSignature(new int[] { 16706814, 16711422, 16679166, 16675582, 16710654, 16710910, 15362538, 15099366 }, GemColor.Orange);

            // Fire ORANGE
            AddSignature(new int[] { 16772607, 16777215, 16744959, 16741887, 16776447, 16776703, 15428587, 15165415 }, GemColor.Orange);

            // Glowing ORANGE
            AddSignature(new int[] { 16777215, 16777215, 16616445, 16679166, 16777215, 16777215, 16754175, 16752895 }, GemColor.Orange);
            AddSignature(new int[] { 16777215, 16777215, 16750847, 16749055, 16777215, 16777215, 16752127, 16751103 }, GemColor.Orange);
            AddSignature(new int[] { 16777215, 16777215, 16755711, 16755199, 16777215, 16777215, 16749823, 16748799 }, GemColor.Orange);
            AddSignature(new int[] { 16777215, 16777215, 16760319, 16759551, 16777215, 16777215, 16748287, 16747263 }, GemColor.Orange);
            AddSignature(new int[] { 16777215, 16777215, 16762367, 16761087, 16777215, 16777215, 16753663, 16752639 }, GemColor.Orange);
            AddSignature(new int[] { 16777215, 16777215, 16761855, 16759039, 16777215, 16777215, 16765695, 16763903 }, GemColor.Orange);
            AddSignature(new int[] { 16777215, 16777215, 16759039, 16755455, 16777215, 16777215, 16762111, 16760319 }, GemColor.Orange);
            AddSignature(new int[] { 16776959, 16777215, 16755199, 16750591, 16777215, 16777215, 16758271, 16756991 }, GemColor.Orange);
            AddSignature(new int[] { 16774911, 16777215, 16751103, 16746239, 16777215, 16777215, 16757759, 16756735 }, GemColor.Orange);
            AddSignature(new int[] { 16708094, 16711678, 16551164, 16415738, 16777215, 16777215, 16757759, 16756735 }, GemColor.Orange);
            AddSignature(new int[] { 16510203, 16514811, 16221431, 16152310, 16777215, 16777215, 16757503, 16755967 }, GemColor.Orange);
            AddSignature(new int[] { 16575996, 16711678, 16023540, 16019956, 16777215, 16777215, 16756991, 16755967 }, GemColor.Orange);
            AddSignature(new int[] { 16777215, 16777215, 15891954, 15954163, 16777215, 16777215, 16754943, 16753663 }, GemColor.Orange);
            AddSignature(new int[] { 16777215, 16777215, 16155382, 16414970, 16777215, 16777215, 16752895, 16751615 }, GemColor.Orange);
            AddSignature(new int[] { 16777215, 16777215, 16749823, 16748287, 16777215, 16777215, 16756991, 16756223 }, GemColor.Orange);
            AddSignature(new int[] { 16777215, 16777215, 16755199, 16754431, 16777215, 16777215, 16769023, 16766975 }, GemColor.Orange);
            AddSignature(new int[] { 16777215, 16777215, 16760319, 16759551, 16777215, 16777215, 16765951, 16763903 }, GemColor.Orange);
            AddSignature(new int[] { 16777215, 16777215, 16762367, 16761087, 16777215, 16777215, 16762111, 16760319 }, GemColor.Orange);
            AddSignature(new int[] { 16777215, 16777215, 16761855, 16759039, 16777215, 16777215, 16761087, 16760063 }, GemColor.Orange);
            AddSignature(new int[] { 16777215, 16777215, 16759039, 16755455, 16777215, 16777215, 16760319, 16759295 }, GemColor.Orange);
            AddSignature(new int[] { 16775167, 16777215, 16750847, 16745983, 16777215, 16777215, 16759039, 16757759 }, GemColor.Orange);
            AddSignature(new int[] { 16777215, 16777215, 16485371, 16415738, 16777215, 16777215, 16756479, 16755455 }, GemColor.Orange);

            // x2 ORANGE
            AddSignature(new int[] { 16777215, 15302121, 16777215, 15658734, 16087797, 16744447, 16547324, 16415994 }, GemColor.Orange);

            // x3 ORANGE
            AddSignature(new int[] { 16777215, 7224174, 16777215, 14540253, 16087797, 14511837, 16547324, 15496684 }, GemColor.Orange);

            // x4 ORANGE
            AddSignature(new int[] { 16777215, 16777215, 16777215, 3480117, 10177947, 5388882, 7748470, 11184810 }, GemColor.Orange);

            // x5 ORANGE
            AddSignature(new int[] { 14737376, 16777215, 14540253, 12303291, 12607424, 13395404, 14708704, 15365354 }, GemColor.Orange);

            // x6 ORANGE
            AddSignature(new int[] { 16777215, 14540253, 16777215, 11184810, 5778520, 16777215, 5844057, 16777215 }, GemColor.Orange);

            // x7 ORANGE
            AddSignature(new int[] { 16777215, 12084152, 16777215, 16777215, 15628014, 16744447, 16415994, 16744447 }, GemColor.Orange);

            #endregion

            #region White

            // Basic WHITE
            AddSignature(new int[] { 16711422, 16514043, 10855845, 14474460, 16711422, 16711422, 15198183, 14737632 }, GemColor.White);

            // Fire WHITE
            AddSignature(new int[] { 16777215, 16579836, 10921638, 14540253, 16777215, 16777215, 15263976, 14803425 }, GemColor.White);

            // Glowing WHITE
            AddSignature(new int[] { 16777215, 16777215, 13887699, 16777215, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 13821650, 16777215, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 13163464, 16580604, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 12373180, 15596781, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 11582640, 14871522, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16711678, 16515067, 10989479, 14344410, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16514811, 16317432, 10659746, 14080982, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16580604, 16515067, 10461855, 13948628, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 10330269, 13882835, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 10593697, 14343642, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 11581360, 15463403, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 13557966, 16777215, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 12373180, 15596525, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 11516847, 14805729, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 10923686, 14344410, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 11054760, 14607838, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 11713458, 15595245, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 12766914, 16711678, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 13557966, 16777215, 16777215, 16777215, 16777215, 16383993 }, GemColor.White);
            AddSignature(new int[] { 16777215, 16777215, 12700865, 16646141, 16777215, 16777215, 16777215, 16777215 }, GemColor.White);

            // x2 WHITE
            AddSignature(new int[] { 16777215, 13158600, 16777215, 15658734, 13487565, 14079702, 13882323, 13750737 }, GemColor.White);

            // x3 WHITE
            AddSignature(new int[] { 16777215, 6184542, 16777215, 14540253, 13487565, 12171705, 13882323, 13027014 }, GemColor.White);

            // x4 WHITE
            AddSignature(new int[] { 16777215, 16777215, 16777215, 2894892, 8553090, 4868682, 6513507, 11184810 }, GemColor.White);

            // x5 WHITE
            AddSignature(new int[] { 14737632, 16777215, 14540253, 12303291, 10592673, 11250603, 12369084, 12895428 }, GemColor.White);

            #endregion

            #region Hypercube

            // Real HYPERCUBE
            AddSignature(new int[] { 4137023, 2625064, 15311337, 15119590, 10054041, 14987492, 10711971, 14395867 }, GemColor.Hypercube);
            AddSignature(new int[] { 4075326, 8743301, 15444459, 13144776, 15123174, 11897781, 12030135, 11897781 }, GemColor.Hypercube);
            AddSignature(new int[] { 4142655, 5848921, 16498939, 5911386, 3747385, 7888760, 1048592, 4333634 }, GemColor.Hypercube);
            AddSignature(new int[] { 4140607, 3412788, 14396891, 12094136, 723467, 855821, 394246, 328965 }, GemColor.Hypercube);
            AddSignature(new int[] { 11836340, 5261648, 1051408, 15775216, 3091247, 1709594, 2301219, 1643289 }, GemColor.Hypercube);
            AddSignature(new int[] { 16773887, 7103596, 2368292, 13868755, 11643313, 4933451, 5984859, 2958637 }, GemColor.Hypercube);
            AddSignature(new int[] { 16775167, 6708326, 4933963, 11832500, 16511227, 16379897, 11774131, 10195611 }, GemColor.Hypercube);
            AddSignature(new int[] { 16440570, 6575972, 15654382, 8348799, 14073558, 15719407, 10916262, 11312300 }, GemColor.Hypercube);
            AddSignature(new int[] { 9929111, 9732756, 8021626, 2165537, 5193295, 9206924, 5127502, 6838632 }, GemColor.Hypercube);
            AddSignature(new int[] { 11048360, 16508923, 4144447, 1510423, 4402755, 4402755, 7231086, 4731464 }, GemColor.Hypercube);
            AddSignature(new int[] { 14994404, 16776959, 6579556, 9010057, 10850981, 6311008, 7825271, 8483201 }, GemColor.Hypercube);
            AddSignature(new int[] { 12692161, 16572668, 7500914, 14404315, 16775423, 14074838, 13352139, 9601682 }, GemColor.Hypercube);
            AddSignature(new int[] { 14141143, 12232122, 13883091, 5193295, 14998756, 16777215, 8880007, 13025222 }, GemColor.Hypercube);
            AddSignature(new int[] { 8943496, 14269401, 16777215, 1051152, 3879739, 8814214, 1774619, 2827307 }, GemColor.Hypercube);
            AddSignature(new int[] { 1706522, 7362928, 15525868, 9013641, 2629160, 1246227, 6116957, 1510679 }, GemColor.Hypercube);
            AddSignature(new int[] { 3487029, 13614031, 9342094, 7830135, 3817018, 4605510, 9146763, 12172217 }, GemColor.Hypercube);
            AddSignature(new int[] { 6645349, 8482945, 6905705, 10990759, 15328233, 5985883, 15525868, 7235950 }, GemColor.Hypercube);
            AddSignature(new int[] { 13883859, 5523284, 12960197, 15461355, 6974826, 14343898, 9343630, 15462891 }, GemColor.Hypercube);
            AddSignature(new int[] { 4738120, 4209472, 15263720, 16250871, 16514043, 12698561, 12105656, 9342350 }, GemColor.Hypercube);
            AddSignature(new int[] { 1843228, 7565939, 15065317, 15067365, 8355455, 9671315, 14078934, 10328477 }, GemColor.Hypercube);
            AddSignature(new int[] { 4547653, 12828867, 8355967, 13158600, 7894392, 9735572, 14210264, 15921906 }, GemColor.Hypercube);
            AddSignature(new int[] { 8759941, 1906717, 7829111, 8882823, 790796, 2895148, 6250591, 11447726 }, GemColor.Hypercube);
            AddSignature(new int[] { 10667682, 2631464, 3551542, 10527136, 2105632, 1184018, 1315348, 1051920 }, GemColor.Hypercube);
            AddSignature(new int[] { 12443581, 3227441, 723979, 15198695, 2045983, 1973790, 1451030, 1775387 }, GemColor.Hypercube);
            AddSignature(new int[] { 14086614, 10007960, 1253395, 11644593, 4609350, 5069389, 2041375, 1843996 }, GemColor.Hypercube);
            AddSignature(new int[] { 9416335, 11659185, 4611142, 3093551, 3886907, 5464659, 1845020, 2500902 }, GemColor.Hypercube);
            AddSignature(new int[] { 5076301, 11591088, 8489857, 4276289, 4086846, 3493685, 8888455, 4215872 }, GemColor.Hypercube);
            AddSignature(new int[] { 9944983, 12509630, 3029550, 2103328, 4681031, 5798232, 6392417, 8430464 }, GemColor.Hypercube);
            AddSignature(new int[] { 12245690, 11657137, 3681848, 3356467, 12642240, 8628611, 11326892, 11326380 }, GemColor.Hypercube);
            AddSignature(new int[] { 8039802, 8564610, 4927819, 7174509, 4748616, 10932902, 4155199, 7511154 }, GemColor.Hypercube);
            AddSignature(new int[] { 5998427, 7055211, 10246044, 5794904, 9813397, 4551237, 10930598, 6786663 }, GemColor.Hypercube);
            AddSignature(new int[] { 6256735, 9615762, 10317213, 3489589, 11850676, 11983286, 6322784, 10205083 }, GemColor.Hypercube);
            AddSignature(new int[] { 3361331, 8959624, 5450579, 923150, 3492917, 7508338, 2502182, 3821114 }, GemColor.Hypercube);
            AddSignature(new int[] { 1975582, 7905400, 7552371, 1709082, 67841, 1583128, 922382, 1187602 }, GemColor.Hypercube);
            AddSignature(new int[] { 1574936, 6847592, 15382762, 7820151, 857869, 857869, 1186322, 792076 }, GemColor.Hypercube);
            AddSignature(new int[] { 5389906, 4934475, 16765183, 15576301, 8085115, 2759466, 9598354, 4010301 }, GemColor.Hypercube);
            AddSignature(new int[] { 15515372, 7103596, 16303864, 8271998, 16764159, 16305400, 13866707, 13869779 }, GemColor.Hypercube);
            AddSignature(new int[] { 11702962, 5787224, 10186395, 4791113, 13999061, 16367353, 12157369, 12288443 }, GemColor.Hypercube);
            AddSignature(new int[] { 2366500, 9135243, 4987468, 9919383, 5711959, 10644130, 8080763, 10447007 }, GemColor.Hypercube);
            AddSignature(new int[] { 2372900, 15778288, 9852822, 14853346, 2363684, 3019310, 1771547, 3347763 }, GemColor.Hypercube);
            AddSignature(new int[] { 3626551, 7886712, 14391259, 16759551, 1116945, 1117201, 3023662, 2102560 }, GemColor.Hypercube);
            AddSignature(new int[] { 1857820, 1315348, 10578849, 16762111, 2496038, 2365988, 5584981, 6507107 }, GemColor.Hypercube);
            AddSignature(new int[] { 7521138, 990991, 3151408, 11366829, 2168353, 1574168, 1968158, 2887468 }, GemColor.Hypercube);
            AddSignature(new int[] { 11465646, 4612166, 1513495, 6627685, 600329, 726539, 1714202, 1842460 }, GemColor.Hypercube);
            AddSignature(new int[] { 6598244, 5732695, 1057808, 11037608, 8366975, 3824442, 4285249, 2044959 }, GemColor.Hypercube);
            AddSignature(new int[] { 5808728, 6526307, 7706997, 10380190, 8898183, 10279836, 10342301, 7512178 }, GemColor.Hypercube);
            AddSignature(new int[] { 7186029, 7841655, 5972059, 6981994, 5278288, 5477459, 5935194, 6529891 }, GemColor.Hypercube);
            AddSignature(new int[] { 6398049, 11068584, 10116250, 4280897, 6787175, 9820565, 5203535, 8106363 }, GemColor.Hypercube);
            AddSignature(new int[] { 5407314, 11922613, 12943045, 329989, 2965805, 5073229, 989711, 2636328 }, GemColor.Hypercube);
            AddSignature(new int[] { 1847836, 9886614, 13401292, 2165537, 1906717, 2963501, 1901853, 2037791 }, GemColor.Hypercube);
            AddSignature(new int[] { 1315092, 7450993, 14255321, 4398147, 2033695, 1444886, 6438498, 3809338 }, GemColor.Hypercube);
            AddSignature(new int[] { 2493222, 5668694, 14124759, 10776228, 10385822, 5256528, 14396635, 12687553 }, GemColor.Hypercube);
            AddSignature(new int[] { 5979483, 6783847, 14058198, 10182299, 6369633, 13278666, 7486066, 9855382 }, GemColor.Hypercube);
            AddSignature(new int[] { 8609923, 5329745, 13929940, 11496367, 10383006, 5316689, 13737169, 9854870 }, GemColor.Hypercube);
            AddSignature(new int[] { 4138815, 2102048, 4072766, 16239863, 1776923, 1381909, 525320, 1380629 }, GemColor.Hypercube);
            AddSignature(new int[] { 3811898, 11969462, 16645629, 1971742, 1444630, 2234402, 1576728, 1379093 }, GemColor.Hypercube);
            AddSignature(new int[] { 8504449, 11859380, 9485200, 3414068, 10539680, 9093770, 10933670, 11263915 }, GemColor.Hypercube);
            AddSignature(new int[] { 9695635, 11532719, 1980702, 1248787, 6132829, 8170876, 9487504, 8038778 }, GemColor.Hypercube);
            AddSignature(new int[] { 11925173, 8501121, 4604486, 3427124, 7055979, 5345873, 6266975, 7714421 }, GemColor.Hypercube);
            AddSignature(new int[] { 10348957, 3960636, 4138559, 11195818, 11728562, 11597744, 12384956, 11267499 }, GemColor.Hypercube);

            // vvv BELOW ARE SNAPSHOTS vvv

            //AddSignature(new int[] { 4137023, 2625064, 15311337, 15119590, 10054041, 14987492, 10711971, 14395867 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4075326, 8743301, 15444459, 13144776, 15123174, 11897781, 12030135, 11897781 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4142655, 5848921, 16498939, 5911386, 3747385, 7888760, 1048592, 4333634 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4140607, 3412788, 14396891, 12094136, 723467, 855821, 394246, 328965 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11836340, 5261648, 1051408, 15775216, 3091247, 1709594, 2301219, 1643289 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16773887, 7103596, 2368292, 13868755, 11643313, 4933451, 5984859, 2958637 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16775167, 6708326, 4933963, 11832500, 16511227, 16379897, 11774131, 10195611 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16440570, 6575972, 15654382, 8348799, 14073558, 15719407, 10916262, 11312300 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9929111, 9732756, 8021626, 2165537, 5193295, 9206924, 5127502, 6838632 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11048360, 16508923, 4144447, 1510423, 4402755, 4402755, 7231086, 4731464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14994404, 16776959, 6579556, 9010057, 10850981, 6311008, 7825271, 8483201 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12692161, 16572668, 7500914, 14404315, 16775423, 14074838, 13352139, 9601682 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14141143, 12232122, 13883091, 5193295, 14998756, 16777215, 8880007, 13025222 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8943496, 14269401, 16777215, 1051152, 3879739, 8814214, 1774619, 2827307 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1706522, 7362928, 15525868, 9013641, 2629160, 1246227, 6116957, 1510679 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3487029, 13614031, 9342094, 7830135, 3817018, 4605510, 9146763, 12172217 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6645349, 8482945, 6905705, 10990759, 15328233, 5985883, 15525868, 7235950 }, GemColor.Hypercube);
            //AddSignature(new int[] { 13883859, 5523284, 12960197, 15461355, 6974826, 14343898, 9343630, 15462891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4738120, 4209472, 15263720, 16250871, 16514043, 12698561, 12105656, 9342350 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1843228, 7565939, 15065317, 15067365, 8355455, 9671315, 14078934, 10328477 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4547653, 12828867, 8355967, 13158600, 7894392, 9735572, 14210264, 15921906 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8759941, 1906717, 7829111, 8882823, 790796, 2895148, 6250591, 11447726 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10667682, 2631464, 3551542, 10527136, 2105632, 1184018, 1315348, 1051920 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12443581, 3227441, 723979, 15198695, 2045983, 1973790, 1451030, 1775387 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14086614, 10007960, 1253395, 11644593, 4609350, 5069389, 2041375, 1843996 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9416335, 11659185, 4611142, 3093551, 3886907, 5464659, 1845020, 2500902 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5076301, 11591088, 8489857, 4276289, 4086846, 3493685, 8888455, 4215872 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9944983, 12509630, 3029550, 2103328, 4681031, 5798232, 6392417, 8430464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12245690, 11657137, 3681848, 3356467, 12642240, 8628611, 11326892, 11326380 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8039802, 8564610, 4927819, 7174509, 4748616, 10932902, 4155199, 7511154 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5998427, 7055211, 10246044, 5794904, 9813397, 4551237, 10930598, 6786663 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6256735, 9615762, 10317213, 3489589, 11850676, 11983286, 6322784, 10205083 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3361331, 8959624, 5450579, 923150, 3492917, 7508338, 2502182, 3821114 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1975582, 7905400, 7552371, 1709082, 67841, 1583128, 922382, 1187602 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1574936, 6847592, 15382762, 7820151, 857869, 857869, 1186322, 792076 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5389906, 4934475, 16765183, 15576301, 8085115, 2759466, 9598354, 4010301 }, GemColor.Hypercube);
            //AddSignature(new int[] { 15515372, 7103596, 16303864, 8271998, 16764159, 16305400, 13866707, 13869779 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11702962, 5787224, 10186395, 4791113, 13999061, 16367353, 12157369, 12288443 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2366500, 9135243, 4987468, 9919383, 5711959, 10644130, 8080763, 10447007 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2372900, 15778288, 9852822, 14853346, 2363684, 3019310, 1771547, 3347763 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3626551, 7886712, 14391259, 16759551, 1116945, 1117201, 3023662, 2102560 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1857820, 1315348, 10578849, 16762111, 2496038, 2365988, 5584981, 6507107 }, GemColor.Hypercube);
            //AddSignature(new int[] { 7521138, 990991, 3151408, 11366829, 2168353, 1574168, 1968158, 2887468 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11465646, 4612166, 1513495, 6627685, 600329, 726539, 1714202, 1842460 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6598244, 5732695, 1057808, 11037608, 8366975, 3824442, 4285249, 2044959 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5808728, 6526307, 7706997, 10380190, 8898183, 10279836, 10342301, 7512178 }, GemColor.Hypercube);

            //AddSignature(new int[] { 7186029, 7841655, 5972059, 6981994, 5278288, 5477459, 5935194, 6529891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6398049, 11068584, 10116250, 4280897, 6787175, 9820565, 5203535, 8106363 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5407314, 11922613, 12943045, 329989, 2965805, 5073229, 989711, 2636328 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1847836, 9886614, 13401292, 2165537, 1906717, 2963501, 1901853, 2037791 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1315092, 7450993, 14255321, 4398147, 2033695, 1444886, 6438498, 3809338 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2493222, 5668694, 14124759, 10776228, 10385822, 5256528, 14396635, 12687553 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5979483, 6783847, 14058198, 10182299, 6369633, 13278666, 7486066, 9855382 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8609923, 5329745, 13929940, 11496367, 10383006, 5316689, 13737169, 9854870 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4137023, 2625064, 15311337, 15119590, 10054041, 14987492, 10711971, 14395867 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4075326, 8743301, 15444459, 13144776, 15123174, 11897781, 12030135, 11897781 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4142655, 5848921, 16498939, 5911386, 3747385, 7888760, 1048592, 4333634 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4140607, 3412788, 14396891, 12094136, 723467, 855821, 394246, 328965 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4138815, 2102048, 4072766, 16239863, 1776923, 1381909, 525320, 1380629 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11836340, 5261648, 1051408, 15775216, 3091247, 1709594, 2301219, 1643289 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16773887, 7103596, 2368292, 13868755, 11643313, 4933451, 5984859, 2958637 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16775167, 6708326, 4933963, 11832500, 16511227, 16379897, 11774131, 10195611 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16440570, 6575972, 15654382, 8348799, 14073558, 15719407, 10916262, 11312300 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9929111, 9732756, 8021626, 2165537, 5193295, 9206924, 5127502, 6838632 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11048360, 16508923, 4144447, 1510423, 4402755, 4402755, 7231086, 4731464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14994404, 16776959, 6579556, 9010057, 10850981, 6311008, 7825271, 8483201 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12692161, 16572668, 7500914, 14404315, 16775423, 14074838, 13352139, 9601682 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14141143, 12232122, 13883091, 5193295, 14998756, 16777215, 8880007, 13025222 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8943496, 14269401, 16777215, 1051152, 3879739, 8814214, 1774619, 2827307 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3811898, 11969462, 16645629, 1971742, 1444630, 2234402, 1576728, 1379093 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3487029, 13614031, 9342094, 7830135, 3817018, 4605510, 9146763, 12172217 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6645349, 8482945, 6905705, 10990759, 15328233, 5985883, 15525868, 7235950 }, GemColor.Hypercube);
            //AddSignature(new int[] { 13883859, 5523284, 12960197, 15461355, 6974826, 14343898, 9343630, 15462891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4738120, 4209472, 15263720, 16250871, 16514043, 12698561, 12105656, 9342350 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1843228, 7565939, 15065317, 15067365, 8355455, 9671315, 14078934, 10328477 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4547653, 12828867, 8355967, 13158600, 7894392, 9735572, 14210264, 15921906 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8759941, 1906717, 7829111, 8882823, 790796, 2895148, 6250591, 11447726 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10667682, 2631464, 3551542, 10527136, 2105632, 1184018, 1315348, 1051920 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12443581, 3227441, 723979, 15198695, 2045983, 1973790, 1451030, 1775387 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14086614, 10007960, 1253395, 11644593, 4609350, 5069389, 2041375, 1843996 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9416335, 11659185, 4611142, 3093551, 3886907, 5464659, 1845020, 2500902 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5076301, 11591088, 8489857, 4276289, 4086846, 3493685, 8888455, 4215872 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9944983, 12509630, 3029550, 2103328, 4681031, 5798232, 6392417, 8430464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12245690, 11657137, 3681848, 3356467, 12642240, 8628611, 11326892, 11326380 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8039802, 8564610, 4927819, 7174509, 4748616, 10932902, 4155199, 7511154 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5998427, 7055211, 10246044, 5794904, 9813397, 4551237, 10930598, 6786663 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6256735, 9615762, 10317213, 3489589, 11850676, 11983286, 6322784, 10205083 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3361331, 8959624, 5450579, 923150, 3492917, 7508338, 2502182, 3821114 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1975582, 7905400, 7552371, 1709082, 67841, 1583128, 922382, 1187602 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1574936, 6847592, 15382762, 7820151, 857869, 857869, 1186322, 792076 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5389906, 4934475, 16765183, 15576301, 8085115, 2759466, 9598354, 4010301 }, GemColor.Hypercube);
            //AddSignature(new int[] { 15515372, 7103596, 16303864, 8271998, 16764159, 16305400, 13866707, 13869779 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11702962, 5787224, 10186395, 4791113, 13999061, 16367353, 12157369, 12288443 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2366500, 9135243, 4987468, 9919383, 5711959, 10644130, 8080763, 10447007 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2372900, 15778288, 9852822, 14853346, 2363684, 3019310, 1771547, 3347763 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3626551, 7886712, 14391259, 16759551, 1116945, 1117201, 3023662, 2102560 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1857820, 1315348, 10578849, 16762111, 2496038, 2365988, 5584981, 6507107 }, GemColor.Hypercube);
            //AddSignature(new int[] { 7521138, 990991, 3151408, 11366829, 2168353, 1574168, 1968158, 2887468 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11465646, 4612166, 1513495, 6627685, 600329, 726539, 1714202, 1842460 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6598244, 5732695, 1057808, 11037608, 8366975, 3824442, 4285249, 2044959 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5808728, 6526307, 7706997, 10380190, 8898183, 10279836, 10342301, 7512178 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8504449, 11859380, 9485200, 3414068, 10539680, 9093770, 10933670, 11263915 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9695635, 11532719, 1980702, 1248787, 6132829, 8170876, 9487504, 8038778 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11925173, 8501121, 4604486, 3427124, 7055979, 5345873, 6266975, 7714421 }, GemColor.Hypercube);

            //AddSignature(new int[] { 5808728, 6526307, 7706997, 10380190, 8898183, 10279836, 10342301, 7512178 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8504449, 11859380, 9485200, 3414068, 10539680, 9093770, 10933670, 11263915 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9695635, 11532719, 1980702, 1248787, 6132829, 8170876, 9487504, 8038778 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11925173, 8501121, 4604486, 3427124, 7055979, 5345873, 6266975, 7714421 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10348957, 3960636, 4138559, 11195818, 11728562, 11597744, 12384956, 11267499 }, GemColor.Hypercube);
            //AddSignature(new int[] { 7186029, 7841655, 5972059, 6981994, 5278288, 5477459, 5935194, 6529891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6398049, 11068584, 10116250, 4280897, 6787175, 9820565, 5203535, 8106363 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5407314, 11922613, 12943045, 329989, 2965805, 5073229, 989711, 2636328 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1847836, 9886614, 13401292, 2165537, 1906717, 2963501, 1901853, 2037791 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1315092, 7450993, 14255321, 4398147, 2033695, 1444886, 6438498, 3809338 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2493222, 5668694, 14124759, 10776228, 10385822, 5256528, 14396635, 12687553 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5979483, 6783847, 14058198, 10182299, 6369633, 13278666, 7486066, 9855382 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8609923, 5329745, 13929940, 11496367, 10383006, 5316689, 13737169, 9854870 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4137023, 2625064, 15311337, 15119590, 10054041, 14987492, 10711971, 14395867 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4075326, 8743301, 15444459, 13144776, 15123174, 11897781, 12030135, 11897781 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4142655, 5848921, 16498939, 5911386, 3747385, 7888760, 1048592, 4333634 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4140607, 3412788, 14396891, 12094136, 723467, 855821, 394246, 328965 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4138815, 2102048, 4072766, 16239863, 1776923, 1381909, 525320, 1380629 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11836340, 5261648, 1051408, 15775216, 3091247, 1709594, 2301219, 1643289 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16773887, 7103596, 2368292, 13868755, 11643313, 4933451, 5984859, 2958637 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16775167, 6708326, 4933963, 11832500, 16511227, 16379897, 11774131, 10195611 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16440570, 6575972, 15654382, 8348799, 14073558, 15719407, 10916262, 11312300 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9929111, 9732756, 8021626, 2165537, 5193295, 9206924, 5127502, 6838632 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11048360, 16508923, 4144447, 1510423, 4402755, 4402755, 7231086, 4731464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14994404, 16776959, 6579556, 9010057, 10850981, 6311008, 7825271, 8483201 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14141143, 12232122, 13883091, 5193295, 14998756, 16777215, 8880007, 13025222 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8943496, 14269401, 16777215, 1051152, 3879739, 8814214, 1774619, 2827307 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3811898, 11969462, 16645629, 1971742, 1444630, 2234402, 1576728, 1379093 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1706522, 7362928, 15525868, 9013641, 2629160, 1246227, 6116957, 1510679 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3487029, 13614031, 9342094, 7830135, 3817018, 4605510, 9146763, 12172217 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6645349, 8482945, 6905705, 10990759, 15328233, 5985883, 15525868, 7235950 }, GemColor.Hypercube);
            //AddSignature(new int[] { 13883859, 5523284, 12960197, 15461355, 6974826, 14343898, 9343630, 15462891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4738120, 4209472, 15263720, 16250871, 16514043, 12698561, 12105656, 9342350 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1843228, 7565939, 15065317, 15067365, 8355455, 9671315, 14078934, 10328477 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4547653, 12828867, 8355967, 13158600, 7894392, 9735572, 14210264, 15921906 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8759941, 1906717, 7829111, 8882823, 790796, 2895148, 6250591, 11447726 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10667682, 2631464, 3551542, 10527136, 2105632, 1184018, 1315348, 1051920 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12443581, 3227441, 723979, 15198695, 2045983, 1973790, 1451030, 1775387 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14086614, 10007960, 1253395, 11644593, 4609350, 5069389, 2041375, 1843996 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9416335, 11659185, 4611142, 3093551, 3886907, 5464659, 1845020, 2500902 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5076301, 11591088, 8489857, 4276289, 4086846, 3493685, 8888455, 4215872 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9944983, 12509630, 3029550, 2103328, 4681031, 5798232, 6392417, 8430464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12245690, 11657137, 3681848, 3356467, 12642240, 8628611, 11326892, 11326380 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8039802, 8564610, 4927819, 7174509, 4748616, 10932902, 4155199, 7511154 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5998427, 7055211, 10246044, 5794904, 9813397, 4551237, 10930598, 6786663 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6256735, 9615762, 10317213, 3489589, 11850676, 11983286, 6322784, 10205083 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3361331, 8959624, 5450579, 923150, 3492917, 7508338, 2502182, 3821114 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1975582, 7905400, 7552371, 1709082, 67841, 1583128, 922382, 1187602 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1574936, 6847592, 15382762, 7820151, 857869, 857869, 1186322, 792076 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5389906, 4934475, 16765183, 15576301, 8085115, 2759466, 9598354, 4010301 }, GemColor.Hypercube);
            //AddSignature(new int[] { 15515372, 7103596, 16303864, 8271998, 16764159, 16305400, 13866707, 13869779 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11702962, 5787224, 10186395, 4791113, 13999061, 16367353, 12157369, 12288443 }, GemColor.Hypercube);

            //AddSignature(new int[] { 7521138, 990991, 3151408, 11366829, 2168353, 1574168, 1968158, 2887468 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11465646, 4612166, 1513495, 6627685, 600329, 726539, 1714202, 1842460 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6598244, 5732695, 1057808, 11037608, 8366975, 3824442, 4285249, 2044959 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5808728, 6526307, 7706997, 10380190, 8898183, 10279836, 10342301, 7512178 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8504449, 11859380, 9485200, 3414068, 10539680, 9093770, 10933670, 11263915 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9695635, 11532719, 1980702, 1248787, 6132829, 8170876, 9487504, 8038778 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11925173, 8501121, 4604486, 3427124, 7055979, 5345873, 6266975, 7714421 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10348957, 3960636, 4138559, 11195818, 11728562, 11597744, 12384956, 11267499 }, GemColor.Hypercube);
            //AddSignature(new int[] { 7186029, 7841655, 5972059, 6981994, 5278288, 5477459, 5935194, 6529891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6398049, 11068584, 10116250, 4280897, 6787175, 9820565, 5203535, 8106363 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5407314, 11922613, 12943045, 329989, 2965805, 5073229, 989711, 2636328 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1847836, 9886614, 13401292, 2165537, 1906717, 2963501, 1901853, 2037791 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1315092, 7450993, 14255321, 4398147, 2033695, 1444886, 6438498, 3809338 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2493222, 5668694, 14124759, 10776228, 10385822, 5256528, 14396635, 12687553 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5979483, 6783847, 14058198, 10182299, 6369633, 13278666, 7486066, 9855382 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8609923, 5329745, 13929940, 11496367, 10383006, 5316689, 13737169, 9854870 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4137023, 2625064, 15311337, 15119590, 10054041, 14987492, 10711971, 14395867 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4075326, 8743301, 15444459, 13144776, 15123174, 11897781, 12030135, 11897781 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4142655, 5848921, 16498939, 5911386, 3747385, 7888760, 1048592, 4333634 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4140607, 3412788, 14396891, 12094136, 723467, 855821, 394246, 328965 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4138815, 2102048, 4072766, 16239863, 1776923, 1381909, 525320, 1380629 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11836340, 5261648, 1051408, 15775216, 3091247, 1709594, 2301219, 1643289 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16773887, 7103596, 2368292, 13868755, 11643313, 4933451, 5984859, 2958637 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16440570, 6575972, 15654382, 8348799, 14073558, 15719407, 10916262, 11312300 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9929111, 9732756, 8021626, 2165537, 5193295, 9206924, 5127502, 6838632 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11048360, 16508923, 4144447, 1510423, 4402755, 4402755, 7231086, 4731464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14994404, 16776959, 6579556, 9010057, 10850981, 6311008, 7825271, 8483201 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12692161, 16572668, 7500914, 14404315, 16775423, 14074838, 13352139, 9601682 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14141143, 12232122, 13883091, 5193295, 14998756, 16777215, 8880007, 13025222 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8943496, 14269401, 16777215, 1051152, 3879739, 8814214, 1774619, 2827307 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3811898, 11969462, 16645629, 1971742, 1444630, 2234402, 1576728, 1379093 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1706522, 7362928, 15525868, 9013641, 2629160, 1246227, 6116957, 1510679 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3487029, 13614031, 9342094, 7830135, 3817018, 4605510, 9146763, 12172217 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6645349, 8482945, 6905705, 10990759, 15328233, 5985883, 15525868, 7235950 }, GemColor.Hypercube);
            //AddSignature(new int[] { 13883859, 5523284, 12960197, 15461355, 6974826, 14343898, 9343630, 15462891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4738120, 4209472, 15263720, 16250871, 16514043, 12698561, 12105656, 9342350 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1843228, 7565939, 15065317, 15067365, 8355455, 9671315, 14078934, 10328477 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4547653, 12828867, 8355967, 13158600, 7894392, 9735572, 14210264, 15921906 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8759941, 1906717, 7829111, 8882823, 790796, 2895148, 6250591, 11447726 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10667682, 2631464, 3551542, 10527136, 2105632, 1184018, 1315348, 1051920 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12443581, 3227441, 723979, 15198695, 2045983, 1973790, 1451030, 1775387 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14086614, 10007960, 1253395, 11644593, 4609350, 5069389, 2041375, 1843996 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9416335, 11659185, 4611142, 3093551, 3886907, 5464659, 1845020, 2500902 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5076301, 11591088, 8489857, 4276289, 4086846, 3493685, 8888455, 4215872 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9944983, 12509630, 3029550, 2103328, 4681031, 5798232, 6392417, 8430464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12245690, 11657137, 3681848, 3356467, 12642240, 8628611, 11326892, 11326380 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8039802, 8564610, 4927819, 7174509, 4748616, 10932902, 4155199, 7511154 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5998427, 7055211, 10246044, 5794904, 9813397, 4551237, 10930598, 6786663 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6256735, 9615762, 10317213, 3489589, 11850676, 11983286, 6322784, 10205083 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3361331, 8959624, 5450579, 923150, 3492917, 7508338, 2502182, 3821114 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1975582, 7905400, 7552371, 1709082, 67841, 1583128, 922382, 1187602 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1574936, 6847592, 15382762, 7820151, 857869, 857869, 1186322, 792076 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5389906, 4934475, 16765183, 15576301, 8085115, 2759466, 9598354, 4010301 }, GemColor.Hypercube);
            //AddSignature(new int[] { 15515372, 7103596, 16303864, 8271998, 16764159, 16305400, 13866707, 13869779 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11702962, 5787224, 10186395, 4791113, 13999061, 16367353, 12157369, 12288443 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2366500, 9135243, 4987468, 9919383, 5711959, 10644130, 8080763, 10447007 }, GemColor.Hypercube);

            //AddSignature(new int[] { 2372900, 15778288, 9852822, 14853346, 2363684, 3019310, 1771547, 3347763 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3626551, 7886712, 14391259, 16759551, 1116945, 1117201, 3023662, 2102560 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1857820, 1315348, 10578849, 16762111, 2496038, 2365988, 5584981, 6507107 }, GemColor.Hypercube);
            //AddSignature(new int[] { 7521138, 990991, 3151408, 11366829, 2168353, 1574168, 1968158, 2887468 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11465646, 4612166, 1513495, 6627685, 600329, 726539, 1714202, 1842460 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6598244, 5732695, 1057808, 11037608, 8366975, 3824442, 4285249, 2044959 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5808728, 6526307, 7706997, 10380190, 8898183, 10279836, 10342301, 7512178 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8504449, 11859380, 9485200, 3414068, 10539680, 9093770, 10933670, 11263915 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9695635, 11532719, 1980702, 1248787, 6132829, 8170876, 9487504, 8038778 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11925173, 8501121, 4604486, 3427124, 7055979, 5345873, 6266975, 7714421 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10348957, 3960636, 4138559, 11195818, 11728562, 11597744, 12384956, 11267499 }, GemColor.Hypercube);
            //AddSignature(new int[] { 7186029, 7841655, 5972059, 6981994, 5278288, 5477459, 5935194, 6529891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6398049, 11068584, 10116250, 4280897, 6787175, 9820565, 5203535, 8106363 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5407314, 11922613, 12943045, 329989, 2965805, 5073229, 989711, 2636328 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1847836, 9886614, 13401292, 2165537, 1906717, 2963501, 1901853, 2037791 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1315092, 7450993, 14255321, 4398147, 2033695, 1444886, 6438498, 3809338 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5979483, 6783847, 14058198, 10182299, 6369633, 13278666, 7486066, 9855382 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8609923, 5329745, 13929940, 11496367, 10383006, 5316689, 13737169, 9854870 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4137023, 2625064, 15311337, 15119590, 10054041, 14987492, 10711971, 14395867 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4075326, 8743301, 15444459, 13144776, 15123174, 11897781, 12030135, 11897781 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4142655, 5848921, 16498939, 5911386, 3747385, 7888760, 1048592, 4333634 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4140607, 3412788, 14396891, 12094136, 723467, 855821, 394246, 328965 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4138815, 2102048, 4072766, 16239863, 1776923, 1381909, 525320, 1380629 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11836340, 5261648, 1051408, 15775216, 3091247, 1709594, 2301219, 1643289 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16773887, 7103596, 2368292, 13868755, 11643313, 4933451, 5984859, 2958637 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16775167, 6708326, 4933963, 11832500, 16511227, 16379897, 11774131, 10195611 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16440570, 6575972, 15654382, 8348799, 14073558, 15719407, 10916262, 11312300 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9929111, 9732756, 8021626, 2165537, 5193295, 9206924, 5127502, 6838632 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11048360, 16508923, 4144447, 1510423, 4402755, 4402755, 7231086, 4731464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14994404, 16776959, 6579556, 9010057, 10850981, 6311008, 7825271, 8483201 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12692161, 16572668, 7500914, 14404315, 16775423, 14074838, 13352139, 9601682 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14141143, 12232122, 13883091, 5193295, 14998756, 16777215, 8880007, 13025222 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8943496, 14269401, 16777215, 1051152, 3879739, 8814214, 1774619, 2827307 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3811898, 11969462, 16645629, 1971742, 1444630, 2234402, 1576728, 1379093 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1706522, 7362928, 15525868, 9013641, 2629160, 1246227, 6116957, 1510679 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3487029, 13614031, 9342094, 7830135, 3817018, 4605510, 9146763, 12172217 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6645349, 8482945, 6905705, 10990759, 15328233, 5985883, 15525868, 7235950 }, GemColor.Hypercube);
            //AddSignature(new int[] { 13883859, 5523284, 12960197, 15461355, 6974826, 14343898, 9343630, 15462891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4738120, 4209472, 15263720, 16250871, 16514043, 12698561, 12105656, 9342350 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1843228, 7565939, 15065317, 15067365, 8355455, 9671315, 14078934, 10328477 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4547653, 12828867, 8355967, 13158600, 7894392, 9735572, 14210264, 15921906 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8759941, 1906717, 7829111, 8882823, 790796, 2895148, 6250591, 11447726 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10667682, 2631464, 3551542, 10527136, 2105632, 1184018, 1315348, 1051920 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12443581, 3227441, 723979, 15198695, 2045983, 1973790, 1451030, 1775387 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14086614, 10007960, 1253395, 11644593, 4609350, 5069389, 2041375, 1843996 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9416335, 11659185, 4611142, 3093551, 3886907, 5464659, 1845020, 2500902 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5076301, 11591088, 8489857, 4276289, 4086846, 3493685, 8888455, 4215872 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9944983, 12509630, 3029550, 2103328, 4681031, 5798232, 6392417, 8430464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12245690, 11657137, 3681848, 3356467, 12642240, 8628611, 11326892, 11326380 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8039802, 8564610, 4927819, 7174509, 4748616, 10932902, 4155199, 7511154 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6256735, 9615762, 10317213, 3489589, 11850676, 11983286, 6322784, 10205083 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3361331, 8959624, 5450579, 923150, 3492917, 7508338, 2502182, 3821114 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1975582, 7905400, 7552371, 1709082, 67841, 1583128, 922382, 1187602 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1574936, 6847592, 15382762, 7820151, 857869, 857869, 1186322, 792076 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5389906, 4934475, 16765183, 15576301, 8085115, 2759466, 9598354, 4010301 }, GemColor.Hypercube);

            //AddSignature(new int[] { 1975582, 7905400, 7552371, 1709082, 67841, 1583128, 922382, 1187602 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1574936, 6847592, 15382762, 7820151, 857869, 857869, 1186322, 792076 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5389906, 4934475, 16765183, 15576301, 8085115, 2759466, 9598354, 4010301 }, GemColor.Hypercube);
            //AddSignature(new int[] { 15515372, 7103596, 16303864, 8271998, 16764159, 16305400, 13866707, 13869779 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11702962, 5787224, 10186395, 4791113, 13999061, 16367353, 12157369, 12288443 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2366500, 9135243, 4987468, 9919383, 5711959, 10644130, 8080763, 10447007 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2372900, 15778288, 9852822, 14853346, 2363684, 3019310, 1771547, 3347763 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3626551, 7886712, 14391259, 16759551, 1116945, 1117201, 3023662, 2102560 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1857820, 1315348, 10578849, 16762111, 2496038, 2365988, 5584981, 6507107 }, GemColor.Hypercube);
            //AddSignature(new int[] { 7521138, 990991, 3151408, 11366829, 2168353, 1574168, 1968158, 2887468 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11465646, 4612166, 1513495, 6627685, 600329, 726539, 1714202, 1842460 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6598244, 5732695, 1057808, 11037608, 8366975, 3824442, 4285249, 2044959 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5808728, 6526307, 7706997, 10380190, 8898183, 10279836, 10342301, 7512178 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8504449, 11859380, 9485200, 3414068, 10539680, 9093770, 10933670, 11263915 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9695635, 11532719, 1980702, 1248787, 6132829, 8170876, 9487504, 8038778 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11925173, 8501121, 4604486, 3427124, 7055979, 5345873, 6266975, 7714421 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10348957, 3960636, 4138559, 11195818, 11728562, 11597744, 12384956, 11267499 }, GemColor.Hypercube);
            //AddSignature(new int[] { 7186029, 7841655, 5972059, 6981994, 5278288, 5477459, 5935194, 6529891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6398049, 11068584, 10116250, 4280897, 6787175, 9820565, 5203535, 8106363 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5407314, 11922613, 12943045, 329989, 2965805, 5073229, 989711, 2636328 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1847836, 9886614, 13401292, 2165537, 1906717, 2963501, 1901853, 2037791 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1315092, 7450993, 14255321, 4398147, 2033695, 1444886, 6438498, 3809338 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2493222, 5668694, 14124759, 10776228, 10385822, 5256528, 14396635, 12687553 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5979483, 6783847, 14058198, 10182299, 6369633, 13278666, 7486066, 9855382 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8609923, 5329745, 13929940, 11496367, 10383006, 5316689, 13737169, 9854870 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4137023, 2625064, 15311337, 15119590, 10054041, 14987492, 10711971, 14395867 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4075326, 8743301, 15444459, 13144776, 15123174, 11897781, 12030135, 11897781 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4142655, 5848921, 16498939, 5911386, 3747385, 7888760, 1048592, 4333634 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4140607, 3412788, 14396891, 12094136, 723467, 855821, 394246, 328965 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4138815, 2102048, 4072766, 16239863, 1776923, 1381909, 525320, 1380629 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11836340, 5261648, 1051408, 15775216, 3091247, 1709594, 2301219, 1643289 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16773887, 7103596, 2368292, 13868755, 11643313, 4933451, 5984859, 2958637 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16775167, 6708326, 4933963, 11832500, 16511227, 16379897, 11774131, 10195611 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16440570, 6575972, 15654382, 8348799, 14073558, 15719407, 10916262, 11312300 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9929111, 9732756, 8021626, 2165537, 5193295, 9206924, 5127502, 6838632 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11048360, 16508923, 4144447, 1510423, 4402755, 4402755, 7231086, 4731464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14994404, 16776959, 6579556, 9010057, 10850981, 6311008, 7825271, 8483201 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12692161, 16572668, 7500914, 14404315, 16775423, 14074838, 13352139, 9601682 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14141143, 12232122, 13883091, 5193295, 14998756, 16777215, 8880007, 13025222 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8943496, 14269401, 16777215, 1051152, 3879739, 8814214, 1774619, 2827307 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3811898, 11969462, 16645629, 1971742, 1444630, 2234402, 1576728, 1379093 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1706522, 7362928, 15525868, 9013641, 2629160, 1246227, 6116957, 1510679 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3487029, 13614031, 9342094, 7830135, 3817018, 4605510, 9146763, 12172217 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6645349, 8482945, 6905705, 10990759, 15328233, 5985883, 15525868, 7235950 }, GemColor.Hypercube);
            //AddSignature(new int[] { 13883859, 5523284, 12960197, 15461355, 6974826, 14343898, 9343630, 15462891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4738120, 4209472, 15263720, 16250871, 16514043, 12698561, 12105656, 9342350 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1843228, 7565939, 15065317, 15067365, 8355455, 9671315, 14078934, 10328477 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4547653, 12828867, 8355967, 13158600, 7894392, 9735572, 14210264, 15921906 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8759941, 1906717, 7829111, 8882823, 790796, 2895148, 6250591, 11447726 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10667682, 2631464, 3551542, 10527136, 2105632, 1184018, 1315348, 1051920 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12443581, 3227441, 723979, 15198695, 2045983, 1973790, 1451030, 1775387 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14086614, 10007960, 1253395, 11644593, 4609350, 5069389, 2041375, 1843996 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9416335, 11659185, 4611142, 3093551, 3886907, 5464659, 1845020, 2500902 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9944983, 12509630, 3029550, 2103328, 4681031, 5798232, 6392417, 8430464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12245690, 11657137, 3681848, 3356467, 12642240, 8628611, 11326892, 11326380 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8039802, 8564610, 4927819, 7174509, 4748616, 10932902, 4155199, 7511154 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5998427, 7055211, 10246044, 5794904, 9813397, 4551237, 10930598, 6786663 }, GemColor.Hypercube);

            //AddSignature(new int[] { 6256735, 9615762, 10317213, 3489589, 11850676, 11983286, 6322784, 10205083 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3361331, 8959624, 5450579, 923150, 3492917, 7508338, 2502182, 3821114 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1975582, 7905400, 7552371, 1709082, 67841, 1583128, 922382, 1187602 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1574936, 6847592, 15382762, 7820151, 857869, 857869, 1186322, 792076 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5389906, 4934475, 16765183, 15576301, 8085115, 2759466, 9598354, 4010301 }, GemColor.Hypercube);
            //AddSignature(new int[] { 15515372, 7103596, 16303864, 8271998, 16764159, 16305400, 13866707, 13869779 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11702962, 5787224, 10186395, 4791113, 13999061, 16367353, 12157369, 12288443 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2366500, 9135243, 4987468, 9919383, 5711959, 10644130, 8080763, 10447007 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2372900, 15778288, 9852822, 14853346, 2363684, 3019310, 1771547, 3347763 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3626551, 7886712, 14391259, 16759551, 1116945, 1117201, 3023662, 2102560 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1857820, 1315348, 10578849, 16762111, 2496038, 2365988, 5584981, 6507107 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11465646, 4612166, 1513495, 6627685, 600329, 726539, 1714202, 1842460 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6598244, 5732695, 1057808, 11037608, 8366975, 3824442, 4285249, 2044959 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5808728, 6526307, 7706997, 10380190, 8898183, 10279836, 10342301, 7512178 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8504449, 11859380, 9485200, 3414068, 10539680, 9093770, 10933670, 11263915 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9695635, 11532719, 1980702, 1248787, 6132829, 8170876, 9487504, 8038778 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11925173, 8501121, 4604486, 3427124, 7055979, 5345873, 6266975, 7714421 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10348957, 3960636, 4138559, 11195818, 11728562, 11597744, 12384956, 11267499 }, GemColor.Hypercube);
            //AddSignature(new int[] { 7186029, 7841655, 5972059, 6981994, 5278288, 5477459, 5935194, 6529891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6398049, 11068584, 10116250, 4280897, 6787175, 9820565, 5203535, 8106363 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5407314, 11922613, 12943045, 329989, 2965805, 5073229, 989711, 2636328 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1847836, 9886614, 13401292, 2165537, 1906717, 2963501, 1901853, 2037791 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1315092, 7450993, 14255321, 4398147, 2033695, 1444886, 6438498, 3809338 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2493222, 5668694, 14124759, 10776228, 10385822, 5256528, 14396635, 12687553 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5979483, 6783847, 14058198, 10182299, 6369633, 13278666, 7486066, 9855382 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8609923, 5329745, 13929940, 11496367, 10383006, 5316689, 13737169, 9854870 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4137023, 2625064, 15311337, 15119590, 10054041, 14987492, 10711971, 14395867 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4075326, 8743301, 15444459, 13144776, 15123174, 11897781, 12030135, 11897781 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4142655, 5848921, 16498939, 5911386, 3747385, 7888760, 1048592, 4333634 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4140607, 3412788, 14396891, 12094136, 723467, 855821, 394246, 328965 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4138815, 2102048, 4072766, 16239863, 1776923, 1381909, 525320, 1380629 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11836340, 5261648, 1051408, 15775216, 3091247, 1709594, 2301219, 1643289 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16773887, 7103596, 2368292, 13868755, 11643313, 4933451, 5984859, 2958637 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16775167, 6708326, 4933963, 11832500, 16511227, 16379897, 11774131, 10195611 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16440570, 6575972, 15654382, 8348799, 14073558, 15719407, 10916262, 11312300 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9929111, 9732756, 8021626, 2165537, 5193295, 9206924, 5127502, 6838632 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11048360, 16508923, 4144447, 1510423, 4402755, 4402755, 7231086, 4731464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14994404, 16776959, 6579556, 9010057, 10850981, 6311008, 7825271, 8483201 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12692161, 16572668, 7500914, 14404315, 16775423, 14074838, 13352139, 9601682 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14141143, 12232122, 13883091, 5193295, 14998756, 16777215, 8880007, 13025222 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8943496, 14269401, 16777215, 1051152, 3879739, 8814214, 1774619, 2827307 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3811898, 11969462, 16645629, 1971742, 1444630, 2234402, 1576728, 1379093 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1706522, 7362928, 15525868, 9013641, 2629160, 1246227, 6116957, 1510679 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3487029, 13614031, 9342094, 7830135, 3817018, 4605510, 9146763, 12172217 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6645349, 8482945, 6905705, 10990759, 15328233, 5985883, 15525868, 7235950 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4738120, 4209472, 15263720, 16250871, 16514043, 12698561, 12105656, 9342350 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1843228, 7565939, 15065317, 15067365, 8355455, 9671315, 14078934, 10328477 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4547653, 12828867, 8355967, 13158600, 7894392, 9735572, 14210264, 15921906 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8759941, 1906717, 7829111, 8882823, 790796, 2895148, 6250591, 11447726 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10667682, 2631464, 3551542, 10527136, 2105632, 1184018, 1315348, 1051920 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12443581, 3227441, 723979, 15198695, 2045983, 1973790, 1451030, 1775387 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14086614, 10007960, 1253395, 11644593, 4609350, 5069389, 2041375, 1843996 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9416335, 11659185, 4611142, 3093551, 3886907, 5464659, 1845020, 2500902 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5076301, 11591088, 8489857, 4276289, 4086846, 3493685, 8888455, 4215872 }, GemColor.Hypercube);

            //AddSignature(new int[] { 12245690, 11657137, 3681848, 3356467, 12642240, 8628611, 11326892, 11326380 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8039802, 8564610, 4927819, 7174509, 4748616, 10932902, 4155199, 7511154 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5998427, 7055211, 10246044, 5794904, 9813397, 4551237, 10930598, 6786663 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6256735, 9615762, 10317213, 3489589, 11850676, 11983286, 6322784, 10205083 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3361331, 8959624, 5450579, 923150, 3492917, 7508338, 2502182, 3821114 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1574936, 6847592, 15382762, 7820151, 857869, 857869, 1186322, 792076 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5389906, 4934475, 16765183, 15576301, 8085115, 2759466, 9598354, 4010301 }, GemColor.Hypercube);
            //AddSignature(new int[] { 15515372, 7103596, 16303864, 8271998, 16764159, 16305400, 13866707, 13869779 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11702962, 5787224, 10186395, 4791113, 13999061, 16367353, 12157369, 12288443 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2366500, 9135243, 4987468, 9919383, 5711959, 10644130, 8080763, 10447007 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2372900, 15778288, 9852822, 14853346, 2363684, 3019310, 1771547, 3347763 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3626551, 7886712, 14391259, 16759551, 1116945, 1117201, 3023662, 2102560 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1857820, 1315348, 10578849, 16762111, 2496038, 2365988, 5584981, 6507107 }, GemColor.Hypercube);
            //AddSignature(new int[] { 7521138, 990991, 3151408, 11366829, 2168353, 1574168, 1968158, 2887468 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11465646, 4612166, 1513495, 6627685, 600329, 726539, 1714202, 1842460 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6598244, 5732695, 1057808, 11037608, 8366975, 3824442, 4285249, 2044959 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5808728, 6526307, 7706997, 10380190, 8898183, 10279836, 10342301, 7512178 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8504449, 11859380, 9485200, 3414068, 10539680, 9093770, 10933670, 11263915 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9695635, 11532719, 1980702, 1248787, 6132829, 8170876, 9487504, 8038778 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11925173, 8501121, 4604486, 3427124, 7055979, 5345873, 6266975, 7714421 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10348957, 3960636, 4138559, 11195818, 11728562, 11597744, 12384956, 11267499 }, GemColor.Hypercube);
            //AddSignature(new int[] { 7186029, 7841655, 5972059, 6981994, 5278288, 5477459, 5935194, 6529891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6398049, 11068584, 10116250, 4280897, 6787175, 9820565, 5203535, 8106363 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5407314, 11922613, 12943045, 329989, 2965805, 5073229, 989711, 2636328 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1847836, 9886614, 13401292, 2165537, 1906717, 2963501, 1901853, 2037791 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1315092, 7450993, 14255321, 4398147, 2033695, 1444886, 6438498, 3809338 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2493222, 5668694, 14124759, 10776228, 10385822, 5256528, 14396635, 12687553 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8609923, 5329745, 13929940, 11496367, 10383006, 5316689, 13737169, 9854870 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4137023, 2625064, 15311337, 15119590, 10054041, 14987492, 10711971, 14395867 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4075326, 8743301, 15444459, 13144776, 15123174, 11897781, 12030135, 11897781 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4142655, 5848921, 16498939, 5911386, 3747385, 7888760, 1048592, 4333634 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4140607, 3412788, 14396891, 12094136, 723467, 855821, 394246, 328965 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4138815, 2102048, 4072766, 16239863, 1776923, 1381909, 525320, 1380629 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11836340, 5261648, 1051408, 15775216, 3091247, 1709594, 2301219, 1643289 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16773887, 7103596, 2368292, 13868755, 11643313, 4933451, 5984859, 2958637 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16775167, 6708326, 4933963, 11832500, 16511227, 16379897, 11774131, 10195611 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16440570, 6575972, 15654382, 8348799, 14073558, 15719407, 10916262, 11312300 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9929111, 9732756, 8021626, 2165537, 5193295, 9206924, 5127502, 6838632 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11048360, 16508923, 4144447, 1510423, 4402755, 4402755, 7231086, 4731464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14994404, 16776959, 6579556, 9010057, 10850981, 6311008, 7825271, 8483201 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12692161, 16572668, 7500914, 14404315, 16775423, 14074838, 13352139, 9601682 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14141143, 12232122, 13883091, 5193295, 14998756, 16777215, 8880007, 13025222 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8943496, 14269401, 16777215, 1051152, 3879739, 8814214, 1774619, 2827307 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3811898, 11969462, 16645629, 1971742, 1444630, 2234402, 1576728, 1379093 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1706522, 7362928, 15525868, 9013641, 2629160, 1246227, 6116957, 1510679 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3487029, 13614031, 9342094, 7830135, 3817018, 4605510, 9146763, 12172217 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6645349, 8482945, 6905705, 10990759, 15328233, 5985883, 15525868, 7235950 }, GemColor.Hypercube);
            //AddSignature(new int[] { 13883859, 5523284, 12960197, 15461355, 6974826, 14343898, 9343630, 15462891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4738120, 4209472, 15263720, 16250871, 16514043, 12698561, 12105656, 9342350 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1843228, 7565939, 15065317, 15067365, 8355455, 9671315, 14078934, 10328477 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4547653, 12828867, 8355967, 13158600, 7894392, 9735572, 14210264, 15921906 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8759941, 1906717, 7829111, 8882823, 790796, 2895148, 6250591, 11447726 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10667682, 2631464, 3551542, 10527136, 2105632, 1184018, 1315348, 1051920 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14086614, 10007960, 1253395, 11644593, 4609350, 5069389, 2041375, 1843996 }, GemColor.Hypercube);

            //AddSignature(new int[] { 5076301, 11591088, 8489857, 4276289, 4086846, 3493685, 8888455, 4215872 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9944983, 12509630, 3029550, 2103328, 4681031, 5798232, 6392417, 8430464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12245690, 11657137, 3681848, 3356467, 12642240, 8628611, 11326892, 11326380 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8039802, 8564610, 4927819, 7174509, 4748616, 10932902, 4155199, 7511154 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5998427, 7055211, 10246044, 5794904, 9813397, 4551237, 10930598, 6786663 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6256735, 9615762, 10317213, 3489589, 11850676, 11983286, 6322784, 10205083 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3361331, 8959624, 5450579, 923150, 3492917, 7508338, 2502182, 3821114 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1975582, 7905400, 7552371, 1709082, 67841, 1583128, 922382, 1187602 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1574936, 6847592, 15382762, 7820151, 857869, 857869, 1186322, 792076 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5389906, 4934475, 16765183, 15576301, 8085115, 2759466, 9598354, 4010301 }, GemColor.Hypercube);
            //AddSignature(new int[] { 15515372, 7103596, 16303864, 8271998, 16764159, 16305400, 13866707, 13869779 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11702962, 5787224, 10186395, 4791113, 13999061, 16367353, 12157369, 12288443 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2366500, 9135243, 4987468, 9919383, 5711959, 10644130, 8080763, 10447007 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2372900, 15778288, 9852822, 14853346, 2363684, 3019310, 1771547, 3347763 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3626551, 7886712, 14391259, 16759551, 1116945, 1117201, 3023662, 2102560 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1857820, 1315348, 10578849, 16762111, 2496038, 2365988, 5584981, 6507107 }, GemColor.Hypercube);
            //AddSignature(new int[] { 7521138, 990991, 3151408, 11366829, 2168353, 1574168, 1968158, 2887468 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11465646, 4612166, 1513495, 6627685, 600329, 726539, 1714202, 1842460 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6598244, 5732695, 1057808, 11037608, 8366975, 3824442, 4285249, 2044959 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5808728, 6526307, 7706997, 10380190, 8898183, 10279836, 10342301, 7512178 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8504449, 11859380, 9485200, 3414068, 10539680, 9093770, 10933670, 11263915 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9695635, 11532719, 1980702, 1248787, 6132829, 8170876, 9487504, 8038778 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10348957, 3960636, 4138559, 11195818, 11728562, 11597744, 12384956, 11267499 }, GemColor.Hypercube);
            //AddSignature(new int[] { 7186029, 7841655, 5972059, 6981994, 5278288, 5477459, 5935194, 6529891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6398049, 11068584, 10116250, 4280897, 6787175, 9820565, 5203535, 8106363 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5407314, 11922613, 12943045, 329989, 2965805, 5073229, 989711, 2636328 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1847836, 9886614, 13401292, 2165537, 1906717, 2963501, 1901853, 2037791 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1315092, 7450993, 14255321, 4398147, 2033695, 1444886, 6438498, 3809338 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2493222, 5668694, 14124759, 10776228, 10385822, 5256528, 14396635, 12687553 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5979483, 6783847, 14058198, 10182299, 6369633, 13278666, 7486066, 9855382 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8609923, 5329745, 13929940, 11496367, 10383006, 5316689, 13737169, 9854870 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4137023, 2625064, 15311337, 15119590, 10054041, 14987492, 10711971, 14395867 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4075326, 8743301, 15444459, 13144776, 15123174, 11897781, 12030135, 11897781 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4142655, 5848921, 16498939, 5911386, 3747385, 7888760, 1048592, 4333634 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4140607, 3412788, 14396891, 12094136, 723467, 855821, 394246, 328965 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4138815, 2102048, 4072766, 16239863, 1776923, 1381909, 525320, 1380629 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11836340, 5261648, 1051408, 15775216, 3091247, 1709594, 2301219, 1643289 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16773887, 7103596, 2368292, 13868755, 11643313, 4933451, 5984859, 2958637 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16775167, 6708326, 4933963, 11832500, 16511227, 16379897, 11774131, 10195611 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16440570, 6575972, 15654382, 8348799, 14073558, 15719407, 10916262, 11312300 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9929111, 9732756, 8021626, 2165537, 5193295, 9206924, 5127502, 6838632 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11048360, 16508923, 4144447, 1510423, 4402755, 4402755, 7231086, 4731464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14994404, 16776959, 6579556, 9010057, 10850981, 6311008, 7825271, 8483201 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12692161, 16572668, 7500914, 14404315, 16775423, 14074838, 13352139, 9601682 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14141143, 12232122, 13883091, 5193295, 14998756, 16777215, 8880007, 13025222 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8943496, 14269401, 16777215, 1051152, 3879739, 8814214, 1774619, 2827307 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3811898, 11969462, 16645629, 1971742, 1444630, 2234402, 1576728, 1379093 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1706522, 7362928, 15525868, 9013641, 2629160, 1246227, 6116957, 1510679 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3487029, 13614031, 9342094, 7830135, 3817018, 4605510, 9146763, 12172217 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6645349, 8482945, 6905705, 10990759, 15328233, 5985883, 15525868, 7235950 }, GemColor.Hypercube);
            //AddSignature(new int[] { 13883859, 5523284, 12960197, 15461355, 6974826, 14343898, 9343630, 15462891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4738120, 4209472, 15263720, 16250871, 16514043, 12698561, 12105656, 9342350 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1843228, 7565939, 15065317, 15067365, 8355455, 9671315, 14078934, 10328477 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4547653, 12828867, 8355967, 13158600, 7894392, 9735572, 14210264, 15921906 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8759941, 1906717, 7829111, 8882823, 790796, 2895148, 6250591, 11447726 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10667682, 2631464, 3551542, 10527136, 2105632, 1184018, 1315348, 1051920 }, GemColor.Hypercube);

            //AddSignature(new int[] { 4547653, 12828867, 8355967, 13158600, 7894392, 9735572, 14210264, 15921906 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8759941, 1906717, 7829111, 8882823, 790796, 2895148, 6250591, 11447726 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10667682, 2631464, 3551542, 10527136, 2105632, 1184018, 1315348, 1051920 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12443581, 3227441, 723979, 15198695, 2045983, 1973790, 1451030, 1775387 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14086614, 10007960, 1253395, 11644593, 4609350, 5069389, 2041375, 1843996 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5076301, 11591088, 8489857, 4276289, 4086846, 3493685, 8888455, 4215872 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9944983, 12509630, 3029550, 2103328, 4681031, 5798232, 6392417, 8430464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12245690, 11657137, 3681848, 3356467, 12642240, 8628611, 11326892, 11326380 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8039802, 8564610, 4927819, 7174509, 4748616, 10932902, 4155199, 7511154 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5998427, 7055211, 10246044, 5794904, 9813397, 4551237, 10930598, 6786663 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6256735, 9615762, 10317213, 3489589, 11850676, 11983286, 6322784, 10205083 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3361331, 8959624, 5450579, 923150, 3492917, 7508338, 2502182, 3821114 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1975582, 7905400, 7552371, 1709082, 67841, 1583128, 922382, 1187602 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1574936, 6847592, 15382762, 7820151, 857869, 857869, 1186322, 792076 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5389906, 4934475, 16765183, 15576301, 8085115, 2759466, 9598354, 4010301 }, GemColor.Hypercube);
            //AddSignature(new int[] { 15515372, 7103596, 16303864, 8271998, 16764159, 16305400, 13866707, 13869779 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11702962, 5787224, 10186395, 4791113, 13999061, 16367353, 12157369, 12288443 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2366500, 9135243, 4987468, 9919383, 5711959, 10644130, 8080763, 10447007 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2372900, 15778288, 9852822, 14853346, 2363684, 3019310, 1771547, 3347763 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3626551, 7886712, 14391259, 16759551, 1116945, 1117201, 3023662, 2102560 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1857820, 1315348, 10578849, 16762111, 2496038, 2365988, 5584981, 6507107 }, GemColor.Hypercube);
            //AddSignature(new int[] { 7521138, 990991, 3151408, 11366829, 2168353, 1574168, 1968158, 2887468 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11465646, 4612166, 1513495, 6627685, 600329, 726539, 1714202, 1842460 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6598244, 5732695, 1057808, 11037608, 8366975, 3824442, 4285249, 2044959 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5808728, 6526307, 7706997, 10380190, 8898183, 10279836, 10342301, 7512178 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8504449, 11859380, 9485200, 3414068, 10539680, 9093770, 10933670, 11263915 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9695635, 11532719, 1980702, 1248787, 6132829, 8170876, 9487504, 8038778 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11925173, 8501121, 4604486, 3427124, 7055979, 5345873, 6266975, 7714421 }, GemColor.Hypercube);
            //AddSignature(new int[] { 10348957, 3960636, 4138559, 11195818, 11728562, 11597744, 12384956, 11267499 }, GemColor.Hypercube);
            //AddSignature(new int[] { 7186029, 7841655, 5972059, 6981994, 5278288, 5477459, 5935194, 6529891 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6398049, 11068584, 10116250, 4280897, 6787175, 9820565, 5203535, 8106363 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5407314, 11922613, 12943045, 329989, 2965805, 5073229, 989711, 2636328 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1847836, 9886614, 13401292, 2165537, 1906717, 2963501, 1901853, 2037791 }, GemColor.Hypercube);
            //AddSignature(new int[] { 2493222, 5668694, 14124759, 10776228, 10385822, 5256528, 14396635, 12687553 }, GemColor.Hypercube);
            //AddSignature(new int[] { 5979483, 6783847, 14058198, 10182299, 6369633, 13278666, 7486066, 9855382 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8609923, 5329745, 13929940, 11496367, 10383006, 5316689, 13737169, 9854870 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4137023, 2625064, 15311337, 15119590, 10054041, 14987492, 10711971, 14395867 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4075326, 8743301, 15444459, 13144776, 15123174, 11897781, 12030135, 11897781 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4142655, 5848921, 16498939, 5911386, 3747385, 7888760, 1048592, 4333634 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4140607, 3412788, 14396891, 12094136, 723467, 855821, 394246, 328965 }, GemColor.Hypercube);
            //AddSignature(new int[] { 4138815, 2102048, 4072766, 16239863, 1776923, 1381909, 525320, 1380629 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11836340, 5261648, 1051408, 15775216, 3091247, 1709594, 2301219, 1643289 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16773887, 7103596, 2368292, 13868755, 11643313, 4933451, 5984859, 2958637 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16775167, 6708326, 4933963, 11832500, 16511227, 16379897, 11774131, 10195611 }, GemColor.Hypercube);
            //AddSignature(new int[] { 16440570, 6575972, 15654382, 8348799, 14073558, 15719407, 10916262, 11312300 }, GemColor.Hypercube);
            //AddSignature(new int[] { 9929111, 9732756, 8021626, 2165537, 5193295, 9206924, 5127502, 6838632 }, GemColor.Hypercube);
            //AddSignature(new int[] { 11048360, 16508923, 4144447, 1510423, 4402755, 4402755, 7231086, 4731464 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14994404, 16776959, 6579556, 9010057, 10850981, 6311008, 7825271, 8483201 }, GemColor.Hypercube);
            //AddSignature(new int[] { 12692161, 16572668, 7500914, 14404315, 16775423, 14074838, 13352139, 9601682 }, GemColor.Hypercube);
            //AddSignature(new int[] { 14141143, 12232122, 13883091, 5193295, 14998756, 16777215, 8880007, 13025222 }, GemColor.Hypercube);
            //AddSignature(new int[] { 8943496, 14269401, 16777215, 1051152, 3879739, 8814214, 1774619, 2827307 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3811898, 11969462, 16645629, 1971742, 1444630, 2234402, 1576728, 1379093 }, GemColor.Hypercube);
            //AddSignature(new int[] { 1706522, 7362928, 15525868, 9013641, 2629160, 1246227, 6116957, 1510679 }, GemColor.Hypercube);
            //AddSignature(new int[] { 3487029, 13614031, 9342094, 7830135, 3817018, 4605510, 9146763, 12172217 }, GemColor.Hypercube);
            //AddSignature(new int[] { 6645349, 8482945, 6905705, 10990759, 15328233, 5985883, 15525868, 7235950 }, GemColor.Hypercube);
            //AddSignature(new int[] { 13883859, 5523284, 12960197, 15461355, 6974826, 14343898, 9343630, 15462891 }, GemColor.Hypercube);

            #endregion

            // HYPERCUBE OUTPUT
            //StringBuilder sb = new StringBuilder();
            //foreach (Signature sig in _set)
            //{
            //    sb.AppendFormat("AddSignature(new int[] {{ {0} }}, Gem.Hypercube);\r\n", string.Join(", ", sig.Sig));
            //}
            //Console.Write(sb.ToString());
            //System.IO.File.WriteAllText(@"hypercube.txt", sb.ToString());
            //System.Diagnostics.Process.Start(@"hypercube.txt");
        }

        public static GemColor Get(int[] arr)
        {
            return Get(new Signature(arr));
        }

        public static GemColor Get(Signature sig)
        {
            GemColor gem;
            if (_map.TryGetValue(sig, out gem))
            {
                return gem;
            }
            
            foreach (KeyValuePair<Signature, GemColor> kvp in _map)
            {
                if (sig.CompareWithinTolerance(kvp.Key, TOLERANCE))
                {
                    return kvp.Value;
                }
            }

            return GemColor.None;
        }
    }
}
