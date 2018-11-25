using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejeweledBlitzEmperor
{
    static class GemParser
    {
        private static Dictionary<Signature, Gem> _map = new Dictionary<Signature, Gem>();

#if DEBUG
        public static readonly int TOLERANCE = 16;
        public static readonly int MAX_MISMATCHES = 0;
#else
        public static readonly int TOLERANCE = 16;
        public static readonly int MAX_MISMATCHES = 1;
#endif

        // HYPERCUBE SET
        private static HashSet<Signature> _set = new HashSet<Signature>();
        private static void AddSignature(Signature sig, GemColor color, GemType type)
        {
            // HYPERCUBE HELPER
            if (color == GemColor.Hypercube)
            {
                _set.Add(sig);
                _map[sig] = Gem.Get(color, type);
                return;
            }

            // This will throw an exception if we attempt to add duplicates.
            _map.Add(sig, Gem.Get(color, type));

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

        private static void AddSignature(int[] arr, GemColor color, GemType type)
        {
            AddSignature(new Signature(arr), color, type);
        }

        static GemParser()
        {
#region Red

            // Basic RED
            AddSignature(new int[] { 16654142, 16654915, 16654656, 14684971, 16653369, 16587576, 16456503, 16325174 }, GemColor.Red, GemType.Basic);

            // Basic RED (spinning)
            AddSignature(new int[] { 16652858, 15076127, 16660061, 10158089, 11862801, 11993873, 11469327, 11534863 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 16652342, 16653372, 13572915, 10289162, 14029351, 14354974, 13307684, 13305624 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 15015223, 16653629, 11078426, 10027017, 12849703, 15667754, 12390435, 15077414 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 11997732, 13830684, 10225170, 9764873, 11864088, 13043736, 11601686, 12650006 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 16651056, 12910863, 16395600, 9961480, 10879244, 11534349, 10682379, 11272204 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 16651829, 15729688, 16659803, 10420233, 16653888, 14552097, 16654660, 14289954 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 10224397, 15995179, 8912901, 10551305, 16650797, 16650797, 16650796, 16650539 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 9633801, 12064042, 9830411, 10094098, 12519191, 16453673, 12322326, 15732261 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 11339027, 10553365, 12980002, 10027276, 13110560, 12980002, 13504291, 13373733 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 13832230, 12917297, 9437192, 16529246, 16654400, 15802688, 16655431, 16000326 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 8978439, 12720175, 8978439, 14624581, 16654916, 14491451, 16655689, 14885438 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 9175047, 12983090, 9109511, 11341600, 9043973, 10881819, 9043973, 10816282 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 9568265, 12786481, 9830410, 10290964, 10092811, 10223884, 10158348, 10289421 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 11273491, 13504034, 12979488, 15145269, 12979488, 13373219, 13373219, 13766693 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 14554413, 16325690, 16658520, 16662642, 16655172, 16655430, 16656202, 16656460 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 16588091, 16653885, 16661868, 16658005, 16655688, 16655687, 16656461, 16656460 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 16655173, 16653884, 13569826, 12192025, 15472432, 15341103, 14881836, 14750763 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 15275309, 13175581, 11601429, 10486285, 12782108, 12585242, 12388633, 12191768 }, GemColor.Red, GemType.Basic);
            AddSignature(new int[] { 11797522, 11928080, 11865631, 9830409, 10944781, 10879245, 10682636, 10682636 }, GemColor.Red, GemType.Basic);

            // Fire RED
            AddSignature(new int[] { 16720191, 16720964, 16720705, 14751020, 16719418, 16653625, 16522552, 16391223 }, GemColor.Red, GemType.Fire);

            // Glowing RED
            AddSignature(new int[] { 16736141, 16740515, 16724310, 15213891, 16734596, 16734339, 16734081, 16733567 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16743857, 16748232, 16727653, 16201304, 16732282, 16732025, 16732024, 16731766 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16747973, 16750804, 16732541, 16731764, 16730224, 16729710, 16729709, 16729452 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16741803, 16740775, 16739230, 16737682, 16730997, 16730741, 16733570, 16733314 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16735116, 16733316, 16738717, 16735627, 16744628, 16744627, 16745655, 16744625 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16729456, 16728171, 16735889, 16732026, 16748999, 16747971, 16742054, 16741026 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16725597, 16725599, 16732030, 16202850, 16743854, 16742312, 16738196, 16737683 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16723540, 16724312, 16727914, 15477581, 16739483, 16738711, 16737682, 16737424 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16722253, 16723026, 16724569, 14950463, 16738196, 16737939, 16737681, 16737424 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16720967, 16721740, 16722510, 14687031, 16737939, 16737682, 16737424, 16736653 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16721224, 16722767, 16524615, 14554674, 16737681, 16737167, 16736908, 16736651 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16726109, 16729198, 16393028, 14488880, 16735367, 16734853, 16734852, 16734338 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16734854, 16738972, 16656457, 14949689, 16733309, 16733052, 16732794, 16732280 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16743086, 16747716, 16726623, 16069459, 16735369, 16735112, 16736913, 16736913 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16747460, 16750547, 16732026, 16730993, 16748484, 16748227, 16748998, 16747712 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16746946, 16747718, 16737171, 16736138, 16752854, 16751569, 16745910, 16744626 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16741803, 16740775, 16739230, 16737682, 16747197, 16745655, 16742052, 16741025 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16735116, 16733316, 16738717, 16735627, 16742825, 16742053, 16741024, 16740767 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16729199, 16728170, 16735889, 16732026, 16741025, 16740767, 16740252, 16739995 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16724826, 16724827, 16732030, 16202594, 16740510, 16740253, 16739738, 16739480 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16723797, 16725341, 16727656, 15411787, 16739739, 16739226, 16738966, 16738453 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16727912, 16731255, 16724311, 14950462, 16737167, 16736654, 16736395, 16736137 }, GemColor.Red, GemType.Glowing);
            AddSignature(new int[] { 16746946, 16747718, 16737171, 16736138, 16728424, 16728167, 16728165, 16727908 }, GemColor.Red, GemType.Glowing);

            // x2 RED
            AddSignature(new int[] { 7019041, 3737355, 5787472, 16777215, 5703179, 6752013, 3867655, 5047562 }, GemColor.Red, GemType.X2);

            // x3 RED
            AddSignature(new int[] { 16777215, 7212565, 16777215, 14540253, 16060704, 14487325, 16519457, 15470623 }, GemColor.Red, GemType.X3);

            // x4 RED
            AddSignature(new int[] { 7019041, 15790063, 5787472, 2163204, 0, 0, 0, 4144959 }, GemColor.Red, GemType.X4);

            // x5 RED
            AddSignature(new int[] { 7019041, 16777215, 5787472, 16777215, 2818821, 3474183, 1769731, 2949894 }, GemColor.Red, GemType.X5);

            // x6 RED
            AddSignature(new int[] { 6756896, 16777215, 5787472, 13619151, 0, 8355711, 0, 8355711 }, GemColor.Red, GemType.X6);

            // x7 RED
            AddSignature(new int[] { 6887968, 1901317, 5787472, 16777215, 6358541, 7145230, 4916490, 5834251 }, GemColor.Red, GemType.X7);

            // x8 RED
            AddSignature(new int[] { 7019041, 13619151, 5787472, 10461087, 0, 0, 0, 0 }, GemColor.Red, GemType.X8);

            // x9 RED
            AddSignature(new int[] { 6625823, 11513775, 5787472, 16777215, 0, 3682096, 0, 458753 }, GemColor.Red, GemType.X9);

            // x10 RED
            AddSignature(new int[] { 10319224, 1639173, 9636371, 5178634, 16777215, 16777215, 16777215, 16777215 }, GemColor.Red, GemType.X10);

            #endregion

            #region Green

            // Basic GREEN
            AddSignature(new int[] { 4652653, 7536302, 971812, 256025, 5570184, 5897872, 1091362, 1090593 }, GemColor.Green, GemType.Basic);
            
            // Basic GREEN (spinning)
            AddSignature(new int[] { 8322746, 4717933, 42253, 48143, 5963406, 5570181, 493074, 427281 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 29192, 831261, 35083, 40715, 1628463, 1232681, 162058, 96266 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 30729, 508186, 564247, 38411, 96779, 163852, 1354279, 1354535 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 31754, 1160228, 2280507, 31750, 296719, 296976, 3206736, 3273042 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 760858, 2283069, 2678339, 1497134, 1426730, 1625903, 2744646, 2546755 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 8912583, 8191672, 59159, 56596, 8257215, 8126141, 626456, 626200 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 4054368, 3007561, 31241, 44557, 4324713, 3865952, 295440, 295439 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 30217, 371477, 101645, 39947, 701980, 637468, 30730, 30217 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 98572, 232718, 2742596, 1157411, 430356, 496916, 3405397, 3405396 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 1554732, 3865183, 2152506, 907300, 2422081, 2686281, 2083896, 1951797 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 6487701, 8781510, 514332, 60440, 7077545, 7405231, 891676, 825884 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 8781509, 6618773, 59670, 52497, 7470765, 7208615, 559638, 559381 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 28421, 1623342, 33802, 41996, 2685256, 2422080, 163085, 162828 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 30473, 306964, 299793, 39435, 97291, 306196, 692505, 96522 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 31242, 1964857, 1686318, 35082, 229646, 229647, 2743365, 2810184 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 297488, 1223973, 2875207, 2219323, 763420, 830238, 3207505, 3141198 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 2876488, 5766791, 1561390, 515869, 3866210, 4193899, 1489196, 1422377 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 8060598, 8978121, 254488, 59670, 8126142, 8191680, 758810, 758554 }, GemColor.Green, GemType.Basic);
            AddSignature(new int[] { 30729, 1039654, 1092129, 37130, 97548, 97292, 2015797, 2280251 }, GemColor.Green, GemType.Basic);


            // Fire GREEN
            AddSignature(new int[] { 4783982, 7667630, 1103141, 387354, 5701512, 6029200, 1222691, 1221922 }, GemColor.Green, GemType.Fire);

            // Glowing GREEN
            AddSignature(new int[] { 6291357, 8716242, 3735412, 2948968, 10026991, 10289142, 5438087, 5437318 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 5439368, 8126403, 2947937, 1965904, 9830380, 10158068, 5306501, 5240195 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 5308291, 8257477, 2091595, 1177401, 9764841, 10026993, 5174657, 5108096 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 6160278, 9437151, 1498426, 716076, 9175005, 9437157, 4647798, 4581492 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 7864251, 11403263, 1629497, 979505, 8650706, 8978394, 4121196, 4120170 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 9371615, 12910591, 2288200, 1965894, 8126408, 8454096, 3594851, 3594081 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 10092531, 13369343, 3341664, 3080034, 7733182, 8060869, 3264856, 3198551 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 9830384, 12648447, 4128630, 3932024, 7339958, 7667646, 2870096, 2803791 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 8716249, 11206655, 4456321, 4128640, 7733187, 8060876, 3793005, 3792237 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 7471034, 9830380, 4390784, 3735417, 10616831, 11010047, 6422434, 6291356 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 6291358, 8781779, 3735412, 2948968, 11599871, 11796479, 5767057, 5569421 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 5570443, 8257479, 2947937, 1965904, 10551292, 10551295, 4977279, 4976254 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 5242754, 8060864, 2157389, 1243195, 9633769, 9830382, 4911229, 4844923 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 4980603, 7798714, 1564220, 716077, 9371618, 9699306, 4845692, 4844923 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 4783989, 7602100, 1234481, 452645, 9306081, 9633769, 4779899, 4778616 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 4849526, 7798711, 1036586, 320288, 9306079, 9568230, 4713847, 4713078 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 5832587, 9109462, 904999, 254494, 8847317, 9109468, 4318575, 4252013 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 7667636, 11206655, 1168428, 715303, 8454091, 8781779, 3923301, 3922275 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 9306076, 12845055, 2156098, 1834817, 8716247, 9043935, 4517244, 4516732 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 10092530, 13303807, 3275613, 3014495, 11468799, 11862015, 7208881, 7012267 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 9830384, 12648447, 4128630, 3932024, 12386303, 12582911, 6553505, 6422429 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 8716249, 11206655, 4456321, 4128640, 11272191, 11337727, 5767055, 5700492 }, GemColor.Green, GemType.Glowing);
            AddSignature(new int[] { 7471034, 9830380, 4390784, 3735417, 10354679, 10551292, 5569931, 5569162 }, GemColor.Green, GemType.Glowing);

            // x2 GREEN
            AddSignature(new int[] { 1072149, 12292, 5199439, 16777215, 17156, 20229, 11779, 15363 }, GemColor.Green, GemType.X2);

            // x3 GREEN
            AddSignature(new int[] { 16777215, 89095, 16777215, 14540253, 48140, 43275, 49676, 46604 }, GemColor.Green, GemType.X3);

            // x4 GREEN
            AddSignature(new int[] { 1072149, 15724783, 5199439, 6657, 0, 0, 0, 4144959 }, GemColor.Green, GemType.X4);

            // x5 GREEN
            AddSignature(new int[] { 1072149, 16777215, 5199439, 16777215, 8450, 10498, 5377, 8962 }, GemColor.Green, GemType.X5);

            // x6 GREEN
            AddSignature(new int[] { 1071381, 16777215, 5199439, 13619151, 0, 8355711, 0, 8355711 }, GemColor.Green, GemType.X6);

            // x7 GREEN
            AddSignature(new int[] { 1071893, 6402, 5199439, 16777215, 19204, 21509, 14851, 17668 }, GemColor.Green, GemType.X7);

            // x8 GREEN
            AddSignature(new int[] { 16777215, 7829367, 16777215, 6710886, 35849, 16644, 32264, 5598294 }, GemColor.Green, GemType.X8);

            // x9 GREEN
            AddSignature(new int[] { 1070869, 11513775, 5199439, 16777215, 0, 3094063, 0, 1536 }, GemColor.Green, GemType.X9);

            // x10 GREEN
            AddSignature(new int[] { 7313010, 5377, 28935, 15620, 16777215, 16777215, 16777215, 16777215 }, GemColor.Green, GemType.X10);

            #endregion

            #region Blue

            // Basic BLUE
            AddSignature(new int[] { 1670908, 12689, 611787, 40702, 1214204, 1213949, 1150206, 1084414 }, GemColor.Blue, GemType.Basic);
            
            // Basic BLUE (spinning)
            AddSignature(new int[] { 545729, 213930, 18113, 34558, 283863, 217554, 219361, 218588 }, GemColor.Blue, GemType.Basic);
            AddSignature(new int[] { 610231, 13974, 149951, 31230, 16561, 16560, 17084, 17853 }, GemColor.Blue, GemType.Basic);
            AddSignature(new int[] { 1273570, 13458, 479427, 37886, 1082620, 214965, 956414, 151492 }, GemColor.Blue, GemType.Basic);
            AddSignature(new int[] { 1273832, 876238, 17859, 40190, 815356, 749050, 750590, 684030 }, GemColor.Blue, GemType.Basic);

            // Fire BLUE
            AddSignature(new int[] { 1868028, 275601, 1597646, 1090814, 1411068, 1410813, 1412862, 1347070 }, GemColor.Blue, GemType.Fire);

            // Glowing BLUE
            AddSignature(new int[] { 2329343, 934564, 1664725, 1023736, 5361919, 5296127, 5165567, 5033983 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 3185407, 2120126, 1071556, 562411, 4769535, 4703743, 4638719, 4507391 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 4897535, 4095466, 1202627, 825840, 4242687, 4242687, 4112127, 4046079 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 6412543, 5610495, 1861330, 1813247, 3716095, 3716095, 3585791, 3519999 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 7137535, 6071807, 2914794, 2933503, 3320831, 3320575, 3255807, 3124479 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 6874367, 5347839, 3705855, 3789823, 2925823, 2925823, 2861055, 2729727 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 5755135, 3899118, 4035583, 3987967, 3321599, 3321599, 3783935, 3718143 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 4503295, 2515403, 3969535, 3592703, 6218751, 6284543, 6417407, 6219775 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 3318015, 1461682, 3311358, 2802687, 7206143, 7074303, 5758463, 5495295 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 2593279, 934822, 2521067, 1814783, 6152447, 5823487, 4968191, 4902143 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 2263551, 736927, 1730519, 1089530, 5230591, 5099007, 4902143, 4770815 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 2000127, 473497, 1137350, 562412, 4967167, 4967167, 4836607, 4770815 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 1802235, 275603, 807611, 298980, 4901375, 4901375, 4770815, 4704511 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 1868028, 473238, 609716, 166623, 4901119, 4835327, 4704767, 4638975 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 2855935, 1790389, 478129, 100829, 4440063, 4374271, 4309503, 4177919 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 4699647, 3897315, 741558, 561638, 4044799, 4044799, 3914239, 3848191 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 6346239, 5544447, 1729228, 1681407, 4308991, 4308991, 4508159, 4442623 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 7137023, 6006015, 2848743, 2867199, 7074559, 7140095, 7207167, 6943743 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 6874367, 5347839, 3705855, 3789823, 7995391, 7864319, 6548735, 6350847 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 4503295, 2515403, 3969535, 3592703, 5954815, 5823231, 5560831, 5495039 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 3317759, 1396145, 3311358, 2802687, 5625343, 5559807, 5428991, 5363199 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 2461439, 802978, 2521067, 1814527, 5428223, 5428223, 5297407, 5166079 }, GemColor.Blue, GemType.Glowing);
            AddSignature(new int[] { 5755135, 3899118, 4035583, 3987967, 6876671, 6613247, 5758463, 5626367 }, GemColor.Blue, GemType.Glowing);

            // x2 BLUE
            AddSignature(new int[] { 2378347, 861497, 5264728, 16777215, 996695, 1130343, 664635, 864077 }, GemColor.Blue, GemType.X2);

            // x3 BLUE
            AddSignature(new int[] { 2378347, 331285, 5264728, 16777215, 997209, 1196909, 731459, 997467 }, GemColor.Blue, GemType.X3);

            // x4 BLUE
            AddSignature(new int[] { 2378347, 15724784, 5264728, 332833, 0, 0, 0, 4144959 }, GemColor.Blue, GemType.X4);

            // x5 BLUE
            AddSignature(new int[] { 2378347, 16777215, 5264728, 16777215, 465451, 598325, 266523, 465965 }, GemColor.Blue, GemType.X5);

            // x6 BLUE
            AddSignature(new int[] { 2312295, 16777215, 5264728, 13619151, 0, 8355711, 0, 8355711 }, GemColor.Blue, GemType.X6);

            // x7 BLUE
            AddSignature(new int[] { 2312553, 398109, 5264728, 16777215, 1064033, 1196909, 863819, 997209 }, GemColor.Blue, GemType.X7);

            // x8 BLUE
            AddSignature(new int[] { 2378347, 13619151, 5264728, 10461087, 0, 0, 0, 0 }, GemColor.Blue, GemType.X8);

            // x9 BLUE
            AddSignature(new int[] { 2311781, 11513775, 5264728, 16777215, 0, 3159352, 0, 66567 }, GemColor.Blue, GemType.X9);

            #endregion

            #region Yellow

            // Basic YELLOW
            AddSignature(new int[] { 16695311, 16711238, 16711213, 14388480, 16710437, 16710180, 16709156, 16708899 }, GemColor.Yellow, GemType.Basic);

            // Basic YELLOW (spinning)
            AddSignature(new int[] { 14454784, 16572461, 13532928, 9658113, 11236359, 12288780, 14787864, 16565540 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 15703553, 16696093, 16691202, 9787904, 11497985, 13272841, 11562240, 14462232 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 16099081, 16711239, 16711177, 16372772, 15706127, 16099085, 16034832, 16428559 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 16693270, 16711286, 16711172, 16034833, 16702749, 16703774, 16704287, 16705056 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 16695578, 16711288, 16710932, 14060803, 16709413, 16709669, 16709925, 16709926 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 16710441, 16708133, 16711221, 16688896, 16704543, 16704030, 16702493, 16701724 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 16711258, 16692239, 16710693, 16706816, 16694034, 16693265, 16692241, 16560400 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 16711292, 13930249, 16366347, 16711169, 14717442, 14784521, 14193160, 14258951 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 16711274, 14194961, 16699398, 16711170, 16241449, 15571972, 15572228, 14587401 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 16709170, 16038176, 16696835, 16711171, 16708912, 16704296, 16692995, 16691716 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 16708658, 16710206, 15965952, 16708352, 16708657, 16710195, 16624387, 16033027 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 16700200, 16711278, 12088832, 16697600, 16711249, 16710996, 14653446, 14062086 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 13802263, 16711279, 14392320, 16032768, 16700951, 16703265, 11497729, 11564035 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 16099596, 16710963, 9000192, 15112192, 16496664, 16563226, 10775041, 10709505 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 16706848, 16711204, 10315008, 9921280, 16500260, 16637226, 9986818, 10447107 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 14465562, 16711210, 12352256, 9000448, 16709942, 16710200, 10711046, 10842631 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 9066240, 16711242, 13337088, 10448128, 16445494, 16711232, 11302921, 11895308 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 10052609, 16711223, 13994240, 10513414, 9592321, 9920513, 9592321, 9460992 }, GemColor.Yellow, GemType.Basic);
            AddSignature(new int[] { 11958532, 16706351, 13402882, 10184708, 10710277, 10710534, 11697163, 11828748 }, GemColor.Yellow, GemType.Basic);

            // Coin YELLOW
            AddSignature(new int[] { 15509761, 16576168, 10638101, 16170776, 16171788, 14981380, 16698128, 15907341 }, GemColor.Yellow, GemType.Coin);

            // Fire YELLOW
            AddSignature(new int[] { 16761364, 16777034, 16777012, 14520585, 16776230, 16775973, 16774949, 16774692 }, GemColor.Yellow, GemType.Fire);

            // Glowing YELLOW
            AddSignature(new int[] { 16777086, 16777154, 16252488, 14524458, 16777075, 16777074, 16777084, 16777084 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16777108, 16777169, 16777059, 15710280, 16777134, 16777133, 16777137, 16777131 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16777106, 16777156, 16777084, 16632929, 16777152, 16777147, 16777121, 16777117 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16777083, 16777125, 16777095, 16765545, 16777127, 16777121, 16777103, 16777100 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16772444, 16777090, 16777094, 16435810, 16777107, 16777103, 16777099, 16777098 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16766527, 16711528, 16777082, 15645777, 16777099, 16777097, 16777095, 16777094 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16237866, 16120921, 16777063, 14657593, 16777096, 16777095, 16777093, 16777091 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16105765, 16252507, 16187217, 13866786, 16777093, 16777092, 16777089, 16777088 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16765240, 16777077, 15594816, 13405461, 16777081, 16777080, 16777078, 16777076 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16773469, 16777121, 15725887, 13668890, 16777070, 16777069, 16777068, 16777066 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16777089, 16777158, 16383822, 14656303, 16777060, 16777059, 16777059, 16777057 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16777106, 16777156, 16777084, 16632929, 16777042, 16777041, 16777040, 16777039 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16777083, 16777125, 16777095, 16765545, 16777055, 16777055, 16777069, 16777069 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16772444, 16777090, 16777094, 16435810, 16777118, 16777117, 16777122, 16777116 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16766784, 16777065, 16777082, 15645777, 16777137, 16777133, 16777105, 16777101 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16369709, 16252765, 16777063, 14657849, 16777112, 16777106, 16777087, 16777086 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16039972, 16054870, 16252755, 13932580, 16777093, 16777089, 16777085, 16777083 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 15776541, 15791440, 15660610, 13405462, 16777086, 16777085, 16777084, 16777083 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 15578647, 15593546, 15330871, 13142030, 16777085, 16777084, 16777083, 16777080 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 15644440, 15791181, 15132976, 13009673, 16777083, 16777081, 16777079, 16777078 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16632365, 16777068, 15001389, 12943879, 16777073, 16777071, 16777071, 16777069 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16772182, 16777114, 15264818, 13404688, 16777063, 16777062, 16777061, 16777059 }, GemColor.Yellow, GemType.Glowing);
            AddSignature(new int[] { 16777109, 16777170, 16777062, 15776587, 16777050, 16777048, 16777048, 16777047 }, GemColor.Yellow, GemType.Glowing);

            // x2 YELLOW
            AddSignature(new int[] { 7039506, 3749890, 5789775, 16777215, 5591808, 6578944, 3815680, 4934144 }, GemColor.Yellow, GemType.X2);

            // x3 YELLOW
            AddSignature(new int[] { 16777215, 7236612, 16777215, 14540253, 15657472, 14144256, 16118016, 15065344 }, GemColor.Yellow, GemType.X3);

            // x4 YELLOW
            AddSignature(new int[] { 7039506, 15790319, 5789775, 2105344, 0, 0, 0, 4144959 }, GemColor.Yellow, GemType.X4);

            // x5 YELLOW
            AddSignature(new int[] { 7039506, 16777215, 5789775, 16777215, 2763008, 3420928, 1776128, 2894592 }, GemColor.Yellow, GemType.X5);

            // x6 YELLOW
            AddSignature(new int[] { 6776338, 16777215, 5789775, 13619151, 0, 8355711, 0, 8355711 }, GemColor.Yellow, GemType.X6);

            // x7 YELLOW
            AddSignature(new int[] { 6907922, 1907969, 5789775, 16777215, 6184192, 6973440, 4802560, 5723392 }, GemColor.Yellow, GemType.X7);

            // x8 YELLOW

            #endregion

            #region Purple

            // Basic PURPLE
            AddSignature(new int[] { 10027161, 16694782, 16061941, 14356187, 16126198, 15994612, 15798257, 15667183 }, GemColor.Purple, GemType.Basic);

            // Basic PURPLE (spinning)
            AddSignature(new int[] { 13829587, 16658686, 12845252, 14818530, 12387261, 12649665, 11928502, 12190650 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 16058101, 16713727, 10682531, 13636816, 14879203, 15207144, 14354907, 14682848 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 16723967, 16737791, 9633939, 16676350, 16664318, 16666622, 16664574, 16666622 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 16353017, 16774143, 9175180, 16706302, 16701182, 16702974, 16701438, 16703230 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 9963160, 16755455, 9175180, 16687358, 16706302, 16700158, 16706046, 16700670 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 11862197, 16722943, 10487456, 16656638, 16135158, 16665342, 14948068, 16664574 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 16712191, 16655870, 16393210, 16655614, 16652542, 16325881, 16653566, 16653822 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 11272364, 16682750, 16659454, 16670718, 16653054, 16650494, 16653822, 16652542 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 9568402, 16669694, 9502865, 10355614, 15470316, 14945508, 14486493, 14158552 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 9897111, 16716031, 9306254, 9765013, 11600817, 12256443, 11666354, 11731891 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 10684067, 14221785, 9502865, 10879142, 13698257, 12321468, 12780483, 10748068 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 14094295, 16715007, 11733939, 13828307, 16652542, 16654078, 16652542, 16654334 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 16735743, 16748287, 16668670, 15007973, 16679934, 16683006, 16680190, 16683518 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 16764927, 16775167, 16702974, 13238474, 16709374, 16709374, 16709374, 16709630 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 16195063, 16673022, 16695294, 10420383, 16686334, 16683262, 16686590, 16683518 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 8650884, 15144935, 8519810, 15076838, 16655870, 16130550, 16656126, 16261880 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 9109643, 16665854, 9109643, 16729855, 16658942, 16660478, 16659454, 16660734 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 9306254, 16693758, 9175180, 16741887, 11012520, 16686334, 10946983, 16686078 }, GemColor.Purple, GemType.Basic);
            AddSignature(new int[] { 11141802, 16685310, 8847495, 16667646, 10354846, 10748068, 10289309, 10027161 }, GemColor.Purple, GemType.Basic);

            // Fire PURPLE
            AddSignature(new int[] { 10490527, 16761598, 16129525, 14423771, 16193782, 16062196, 15865329, 15734255 }, GemColor.Purple, GemType.Fire);

            // Glowing PURPLE
            AddSignature(new int[] { 11616718, 16772351, 15344886, 13836256, 16731135, 16730623, 16730623, 16730367 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 13131762, 16777215, 16003583, 14823669, 16728831, 16728319, 16728575, 16728575 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 13856767, 16777215, 16729343, 15943935, 16530175, 16463871, 16529663, 16333055 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 13593599, 16777215, 16733951, 16734719, 16135167, 16069119, 16134911, 15938303 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 12474348, 16772607, 16735999, 16736255, 16530943, 16464895, 16730111, 16730111 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 11222477, 16306431, 16735487, 16603135, 16741119, 16740863, 16742143, 16741375 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 10037169, 15252731, 16732671, 15813119, 16745471, 16744191, 16738559, 16737791 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 9312414, 14725871, 16663295, 14825215, 16740351, 16738559, 16734719, 16734463 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 8982677, 14527976, 15872767, 14099946, 16735999, 16734975, 16734207, 16734207 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 8719246, 14264546, 15279609, 13572828, 16734719, 16734207, 16734207, 16734207 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 8521352, 14066652, 14949870, 13309396, 16734463, 16733951, 16733951, 16733439 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 8587145, 14264287, 14751975, 13177039, 16734207, 16733439, 16733439, 16733439 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 9575070, 15581438, 14620388, 13111245, 16731903, 16731135, 16731391, 16731135 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 11418823, 16770815, 14883817, 13572054, 16729855, 16729343, 16729343, 16729087 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 13065455, 16777215, 15871487, 14691824, 16731903, 16731391, 16733439, 16733695 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 13856255, 16777215, 16728831, 15877631, 16744959, 16744447, 16745471, 16744447 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 13593599, 16777215, 16733951, 16734719, 16749311, 16747775, 16742399, 16741375 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 12474348, 16772607, 16735999, 16736255, 16743679, 16741887, 16738559, 16737791 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 11222477, 16306431, 16735487, 16603135, 16739327, 16738303, 16737535, 16737535 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 10036912, 15187194, 16732671, 15813119, 16737535, 16737023, 16736767, 16736767 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 9048470, 14725613, 15806975, 14034152, 16736255, 16735487, 16735487, 16735231 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 9904553, 15911167, 15213815, 13572827, 16733695, 16732927, 16732927, 16732927 }, GemColor.Purple, GemType.Glowing);
            AddSignature(new int[] { 9180571, 14594027, 16663295, 14824959, 16737023, 16736511, 16736255, 16736255 }, GemColor.Purple, GemType.Glowing);

            // x2 PURPLE
            AddSignature(new int[] { 6298464, 3278642, 5721943, 16777215, 4916811, 5834585, 3343411, 4392259 }, GemColor.Purple, GemType.X2);

            // x3 PURPLE
            AddSignature(new int[] { 6298464, 1245715, 5721943, 16777215, 5047885, 6162526, 3802426, 5178959 }, GemColor.Purple, GemType.X3);

            // x4 PURPLE
            AddSignature(new int[] { 6298464, 15790064, 5721943, 1901084, 0, 0, 0, 4144959 }, GemColor.Purple, GemType.X4);

            // x5 PURPLE
            AddSignature(new int[] { 6298464, 16777215, 5721943, 16777215, 2425637, 3015726, 1573400, 2556711 }, GemColor.Purple, GemType.X5);

            // x6 PURPLE
            AddSignature(new int[] { 6036060, 16777215, 5721943, 13619151, 0, 8355711, 0, 8355711 }, GemColor.Purple, GemType.X6);

            // x7 PURPLE
            AddSignature(new int[] { 16777215, 10557601, 16777215, 16777215, 13504973, 14488540, 14160599, 14488540 }, GemColor.Purple, GemType.X7);

            // x8 PURPLE
            AddSignature(new int[] { 6298464, 13619151, 5721943, 10461087, 0, 0, 0, 0 }, GemColor.Purple, GemType.X8);

            // x9 PURPLE

            // x10 PURPLE
            AddSignature(new int[] { 9991575, 1442582, 8325759, 4457796, 16777215, 16777215, 16777215, 16777215 }, GemColor.Purple, GemType.X10);

            #endregion

            #region Orange

            // Basic ORANGE
            AddSignature(new int[] { 16706670, 16711316, 16678942, 16675341, 16710521, 16710782, 15362338, 15099169 }, GemColor.Orange, GemType.Basic);

            // Basic ORANGE (spinning)
            AddSignature(new int[] { 16711331, 16711323, 16672518, 16670721, 16710810, 16710809, 12666898, 12535568 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 16699986, 16698711, 9709570, 16666112, 16707947, 16706148, 11089160, 11023368 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 16693314, 16678432, 10169606, 15810048, 16683308, 16681768, 10365699, 10365442 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 14902556, 16683050, 10957062, 12923136, 10955523, 13980437, 11088134, 11153157 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 10564362, 16680760, 16670743, 10299392, 13913107, 14175764, 14241557, 14504214 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 12667158, 16684092, 16676393, 11152128, 16605726, 16671518, 16672288, 16672544 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 14505241, 16672284, 16674085, 13119744, 16671516, 16671515, 16671773, 16671772 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 16146973, 16673565, 14700821, 14894601, 16669976, 16669976, 16472599, 16407062 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 12399618, 16341014, 12073482, 10760712, 15356179, 15224850, 14896401, 14765072 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 14108687, 12597768, 14440734, 11021570, 14898199, 13122569, 15226904, 12794633 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 15882520, 11808512, 16478508, 12333056, 16672030, 16672030, 16672800, 16672800 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 16670744, 16212764, 16538645, 16674327, 16671002, 16671002, 16671002, 16670746 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 16674852, 15030812, 16667653, 16670477, 16538135, 16407062, 16013077, 15947285 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 16676914, 12206353, 16534022, 16666630, 14567951, 14370830, 14108174, 13976845 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 16545330, 9643778, 15286787, 16664065, 12465669, 12399876, 12203012, 12137476 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 12466696, 14703905, 16670488, 9905408, 12729609, 12925705, 16411175, 16676140 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 13911309, 12599566, 16681779, 11020544, 15553299, 15947284, 16685119, 16685632 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 16677161, 16693323, 16685112, 16680485, 16685879, 16688187, 16683322, 16682552 }, GemColor.Orange, GemType.Basic);
            AddSignature(new int[] { 11283457, 14443553, 12662533, 10233600, 15034654, 12331520, 10953984, 12004865 }, GemColor.Orange, GemType.Basic);

            // Fire ORANGE
            AddSignature(new int[] { 16772463, 16777108, 16744736, 16741647, 16776314, 16776575, 15428387, 15165218 }, GemColor.Orange, GemType.Fire);

            // Glowing ORANGE
            AddSignature(new int[] { 16776843, 16777133, 16755035, 16750404, 16777198, 16777198, 16758143, 16756862 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16774786, 16777126, 16750919, 16746031, 16777179, 16777181, 16757629, 16756603 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16707963, 16711584, 16550966, 16415521, 16777172, 16777177, 16757628, 16756603 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16510069, 16514714, 16221227, 16152089, 16777171, 16777176, 16757371, 16755832 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16575862, 16711581, 16023332, 16019732, 16777169, 16777173, 16756855, 16755830 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777099, 16777148, 15891745, 15953938, 16777159, 16777163, 16754799, 16753517 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777140, 16777194, 16155174, 16414747, 16777149, 16777154, 16752741, 16751459 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777180, 16777215, 16749628, 16748085, 16777161, 16777166, 16756860, 16756092 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777202, 16777215, 16755031, 16754259, 16777215, 16777215, 16768945, 16766891 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777200, 16777215, 16760176, 16759404, 16777215, 16777215, 16765857, 16763805 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777177, 16777205, 16762235, 16760948, 16777213, 16777213, 16761999, 16760204 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777146, 16777170, 16761722, 16758893, 16777193, 16777195, 16760971, 16759946 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777117, 16777144, 16758894, 16755292, 16777185, 16777189, 16760199, 16759174 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16776072, 16777129, 16755035, 16750148, 16777182, 16777187, 16759685, 16758659 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16775043, 16777131, 16750661, 16745773, 16777179, 16777184, 16758913, 16757632 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777110, 16777157, 16485172, 16415520, 16777167, 16777172, 16756342, 16755316 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777147, 16777201, 16616243, 16678949, 16777156, 16777161, 16754028, 16752746 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777183, 16777215, 16750658, 16748858, 16777146, 16777151, 16751971, 16750945 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777203, 16777215, 16755546, 16755030, 16777136, 16777140, 16749656, 16748631 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777200, 16777215, 16760176, 16759404, 16777128, 16777133, 16748112, 16747087 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777177, 16777205, 16762235, 16760948, 16777141, 16777147, 16753517, 16752493 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777146, 16777170, 16761722, 16758893, 16777204, 16777209, 16765602, 16763804 }, GemColor.Orange, GemType.Glowing);
            AddSignature(new int[] { 16777118, 16777145, 16758894, 16755292, 16777215, 16777215, 16762001, 16760205 }, GemColor.Orange, GemType.Glowing);

            // x2 ORANGE
            AddSignature(new int[] { 7028772, 3743501, 5788496, 16777215, 5712655, 6763281, 3874058, 5056013 }, GemColor.Orange, GemType.X2);

            // x3 ORANGE
            AddSignature(new int[] { 7028772, 1379077, 5788496, 16777215, 5843983, 7157266, 4399371, 5975311 }, GemColor.Orange, GemType.X3);

            // x4 ORANGE
            AddSignature(new int[] { 7028772, 15790319, 5788496, 2166789, 0, 0, 0, 4144959 }, GemColor.Orange, GemType.X4);

            // x5 ORANGE
            AddSignature(new int[] { 7028772, 16777215, 5788496, 16777215, 2823431, 3480073, 1772804, 2954759 }, GemColor.Orange, GemType.X5);

            // x6 ORANGE
            AddSignature(new int[] { 6766115, 16777215, 5788496, 13619151, 0, 8355711, 0, 8355711 }, GemColor.Orange, GemType.X6);

            // x7 ORANGE
            AddSignature(new int[] { 16777215, 12084010, 16777215, 16777215, 15627817, 16744236, 16415787, 16744236 }, GemColor.Orange, GemType.X7);

            // x8 ORANGE
            AddSignature(new int[] { 7028772, 13619151, 5788496, 10461087, 0, 0, 0, 0 }, GemColor.Orange, GemType.X8);

            // x9 ORANGE
            AddSignature(new int[] { 6634787, 11513775, 5788496, 16777215, 0, 3683120, 0, 459521 }, GemColor.Orange, GemType.X9);

            // x10 ORANGE
            AddSignature(new int[] { 10324089, 1641733, 9652505, 5187341, 16777215, 16777215, 16777215, 16777215 }, GemColor.Orange, GemType.X10);

            #endregion

            #region White

            // Basic WHITE
            AddSignature(new int[] { 16711422, 16514043, 10855845, 14474460, 16711422, 16711422, 15198183, 14737632 }, GemColor.White, GemType.Basic);

            // Basic WHITE (spinning)
            AddSignature(new int[] { 16711422, 12369084, 11053224, 15658734, 15527148, 14079702, 14145495, 13750737 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 11513775, 10395294, 16448250, 16711422, 16448250, 15724527, 13882323 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 15066597, 16119285, 16711422, 16711422, 16711422, 15987699, 13684944 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 13027014, 15066597, 16711422, 16711422, 16711422, 16711422, 16711422 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 10855845, 11316396, 16711422, 16711422, 16711422, 16711422, 16711422 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 13816530, 11316396, 16579836, 16711422, 16250871, 16316664, 15790320 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 12500670, 15329769, 15263976, 15790320, 14342874, 15198183, 13619151 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 11974326, 15592941, 12500670, 16711422, 16711422, 16711422, 16711422 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 15198183, 14408667, 16579836, 16711422, 16711422, 16711422, 16711422 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 14408667, 9079434, 16711422, 16711422, 16579836, 16579836, 16185078 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 12369084, 11316396, 16711422, 15395562, 14540253, 14737632, 13816530 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 11250603, 15592941, 14474460, 16711422, 15198183, 16711422, 14737632 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 13882323, 15658734, 15329769, 16711422, 16711422, 16711422, 16711422 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 15263976, 14277081, 16711422, 16711422, 16711422, 16711422, 16711422 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 13684944, 9474192, 16382457, 16448250, 15921906, 15987699, 15395562 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 10855845, 15263976, 14408667, 16711422, 16711422, 16711422, 16711422 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 15263976, 13487565, 14803425, 16711422, 16711422, 16711422, 16711422 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 14342874, 11776947, 14013909, 16645629, 16250871, 16250871, 15658734 }, GemColor.White, GemType.Basic);
            AddSignature(new int[] { 16711422, 11447982, 13684944, 16711422, 15658734, 13816530, 15000804, 13092807 }, GemColor.White, GemType.Basic);

            // Fire WHITE
            AddSignature(new int[] { 16777214, 16579835, 10921637, 14540252, 16777214, 16777214, 15263975, 14803424 }, GemColor.White, GemType.Fire);

            // Glowing WHITE
            AddSignature(new int[] { 16777215, 16777215, 13163503, 16580607, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 12373212, 15596799, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 11582664, 14871541, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16711679, 16515071, 10989495, 14344423, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16514815, 16317439, 10659756, 14080991, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16580607, 16515071, 10461861, 13948634, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 10330274, 13882840, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 10593703, 14343649, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 11581373, 15463419, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 12700888, 16646143, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 13558001, 16777215, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 13887740, 16777215, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 13821691, 16777215, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 12373212, 15596543, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 11516870, 14805747, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 10923701, 14344422, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 11054772, 14607851, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 11713475, 15595263, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 12766939, 16711679, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.Glowing);
            AddSignature(new int[] { 16777215, 16777215, 13558001, 16777215, 16777215, 16777215, 16777215, 16383999 }, GemColor.White, GemType.Glowing);

            // x2 WHITE
            AddSignature(new int[] { 6184542, 3223857, 5723991, 16777215, 4802889, 5658198, 3289650, 4276545 }, GemColor.White, GemType.X2);

            // x3 WHITE
            AddSignature(new int[] { 6184542, 1184274, 5723991, 16777215, 4934475, 5987163, 3684408, 5000268 }, GemColor.White, GemType.X3);

            // x4 WHITE
            AddSignature(new int[] { 6184542, 15790320, 5723991, 1842204, 0, 0, 0, 4144959 }, GemColor.White, GemType.X4);

            // x5 WHITE
            AddSignature(new int[] { 6184542, 16777215, 5723991, 16777215, 2368548, 2960685, 1513239, 2500134 }, GemColor.White, GemType.X5);

            // x6 WHITE
            AddSignature(new int[] { 5921370, 16777215, 5723991, 13619151, 0, 8355711, 0, 8355711 }, GemColor.White, GemType.X6);

            // x7 WHITE
            AddSignature(new int[] { 16777215, 10395294, 16777215, 16777215, 13092807, 14079702, 13750737, 14079702 }, GemColor.White, GemType.X7);

            // x8 WHITE
            AddSignature(new int[] { 6184542, 13619151, 5723991, 10461087, 0, 0, 0, 0 }, GemColor.White, GemType.X8);

            // x9 WHITE
            AddSignature(new int[] { 5855577, 11513775, 5723991, 16777215, 0, 3618615, 0, 394758 }, GemColor.White, GemType.X9);

            // x10 WHITE
            AddSignature(new int[] { 9934743, 1447446, 8092539, 4342338, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.X10);

            // x11 WHITE
            AddSignature(new int[] { 9934743, 5131854, 8092539, 10000536, 16777215, 16777215, 16777215, 16777215 }, GemColor.White, GemType.X11);

            #endregion

            #region Hypercube

            // Real HYPERCUBE (includes hint arrows)
            AddSignature(new int[] { 8504442, 11859382, 9485195, 3414036, 10539660, 9093756, 10933655, 11263905 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 9695653, 11532719, 1980701, 1248781, 6132821, 8170864, 9487494, 8038765 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11925165, 8501104, 4604476, 3427122, 7055968, 5345863, 6266969, 7714415 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 10348954, 3960629, 4138563, 11195815, 11728561, 11597740, 12384954, 11267496 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 7186026, 7841638, 5972049, 6981989, 5278283, 5477453, 5935191, 6529889 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6398052, 11068580, 10116246, 4280898, 6787167, 9820555, 5203525, 8106350 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1847830, 9886611, 13401298, 2165531, 1906711, 2963499, 1901848, 2037789 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1315090, 7450991, 14255316, 4398145, 2033691, 1444882, 6438493, 3809332 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2493223, 5668690, 14124757, 10776227, 10385821, 5256527, 14396632, 12687551 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5979484, 6783843, 14058204, 10182301, 6369622, 13278652, 7486055, 9855368 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8609915, 5329737, 13929934, 11496369, 10383008, 5316691, 13737172, 9854872 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4137019, 2625058, 15311330, 15119595, 10054040, 14987488, 10711968, 14395863 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4075285, 8743310, 15444452, 13144769, 15123175, 11897787, 12030141, 11897790 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4142612, 5848934, 16498939, 5911387, 3747386, 7888760, 1048592, 4333632 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4140557, 3412779, 14396886, 12094128, 723474, 855831, 394260, 328982 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4138758, 2102026, 4072773, 16239863, 1776917, 1381905, 525323, 1380632 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11836292, 5261616, 1051402, 15775210, 3091231, 1709584, 2301210, 1643286 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 16773836, 7103563, 2368284, 13868751, 11643287, 4933431, 5984838, 2958622 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 16775117, 6708286, 4933943, 11832496, 16511183, 16379859, 11774096, 10195584 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 16440499, 6575919, 15654334, 8348794, 14073503, 15719357, 10916213, 11312258 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 9929047, 9732689, 8021592, 2165528, 5193263, 9206869, 5127472, 6838585 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11048294, 16508848, 4144423, 1510405, 4402702, 4402704, 7231033, 4731418 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 14994333, 16776912, 6579510, 9010027, 10850925, 6310954, 7825217, 8483147 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 12692091, 16572600, 7500850, 14404275, 16775381, 14074782, 13352098, 9601636 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 14141095, 12232049, 13883021, 5193258, 14998722, 16777186, 8879983, 13025192 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8943456, 14269330, 16777143, 1051136, 3879724, 8814199, 1774614, 2827302 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 3811862, 11969396, 16645570, 1971712, 1444620, 2234382, 1576719, 1379079 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1706504, 7362866, 15525804, 9013604, 2629140, 1246212, 6116924, 1510656 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 3486996, 13613981, 9342031, 7830078, 3816995, 4605495, 9146726, 12172190 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6645305, 8482906, 6905636, 10990688, 15328196, 5985854, 15525828, 7235918 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 13883810, 5523258, 12960135, 15461292, 6974769, 14343844, 9343571, 15462831 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4738097, 4209432, 15263654, 16250814, 16513999, 12698514, 12105605, 9342301 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1843239, 7565903, 15065241, 15067291, 8355403, 9671263, 14078883, 10328430 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4547700, 12828828, 8355921, 13158551, 7894349, 9735519, 14210214, 15921860 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8760007, 1906688, 7829080, 8882771, 790789, 2895128, 6250571, 11447695 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 10667737, 2631453, 3551513, 10527075, 2105623, 1184007, 1315328, 1051904 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 12443646, 3227459, 723970, 15198644, 2046023, 1973787, 1451048, 1775371 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 14086653, 10008005, 1253409, 11644548, 4609379, 5069413, 2041391, 1844008 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 9416394, 11659260, 4611183, 3093523, 3886941, 5464686, 1845044, 2500915 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5076353, 11591149, 8489887, 4276265, 4086897, 3493729, 8888503, 4215911 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 12245756, 11657204, 3681834, 3356477, 12642303, 8628671, 11326954, 11326441 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8039880, 8564681, 4927791, 7174536, 4748679, 10932966, 4155255, 7511213 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5998495, 7055295, 10245979, 5794936, 9813453, 4551300, 10930647, 6786718 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6256785, 9615837, 10317160, 3489607, 11850731, 11983348, 6322827, 10205133 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 3361367, 8959706, 5450527, 923155, 3492949, 7508384, 2502196, 3821144 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1975594, 7905471, 7552312, 1709078, 67855, 1583154, 922386, 1187618 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1574926, 6847640, 15382710, 7820114, 857868, 857871, 1186314, 792072 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5389888, 4934504, 16765136, 15576235, 8085077, 2759443, 9598314, 4010274 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 15515319, 7103598, 16303808, 8271934, 16764103, 16305350, 13866648, 13869729 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11702924, 5787207, 10186352, 4791072, 13998994, 16367283, 12157309, 12288379 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2366485, 9135194, 4987416, 9919316, 5711913, 10644072, 8080723, 10446955 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2372898, 15778242, 9852771, 14853290, 2363658, 3019274, 1771521, 3347726 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 3626546, 7886681, 14391199, 16759480, 1116936, 1117195, 3023647, 2102548 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1857833, 1315342, 10578803, 16762057, 2496018, 2365974, 5584952, 6507083 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 7521148, 990994, 3151381, 11366758, 2168335, 1574148, 1968133, 2887439 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11465643, 4612170, 1513485, 6627612, 600335, 726536, 1714201, 1842451 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6598242, 5732689, 1057812, 11037542, 8366979, 3824443, 4285253, 2044958 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5808726, 6526309, 7706990, 10380130, 8898186, 10279841, 10342303, 7512181 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5407323, 11922605, 12943045, 329987, 2965793, 5073220, 989703, 2636323 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 9945041, 12509679, 3029571, 2103312, 4681093, 5798289, 6392481, 8430522 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 13883810, 5523258, 13091721, 15527085, 6974769, 14343844, 9343571, 15462831 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4738097, 4209432, 15329447, 16316607, 16513999, 12698514, 12171398, 9342301 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1843239, 7565903, 15065241, 15198877, 8355403, 9671263, 14210469, 10328430 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4547700, 12828828, 8355921, 13487516, 7894349, 9735519, 14341800, 16053446 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8760007, 1906688, 8158045, 9014357, 790789, 2895128, 6250571, 11513488 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 14086653, 10008005, 1253409, 11907720, 4609379, 5069413, 2041391, 1844008 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5076353, 11591149, 8489887, 4473644, 4086897, 3493729, 8888503, 4215911 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5979484, 6783843, 14123997, 10182301, 6369622, 13278652, 7486055, 9855368 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8609915, 5329737, 13929934, 11496369, 10383008, 5316691, 13802965, 9854872 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4075285, 8809103, 15444452, 13144769, 15254761, 11897787, 12095934, 12029376 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4140557, 3412779, 14462679, 12225714, 723474, 855831, 394260, 328982 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4138758, 2102026, 4072773, 16305656, 1776917, 1381905, 525323, 1380632 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 16775117, 6708286, 4933943, 11964082, 16511183, 16379859, 11774096, 10195584 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 16440499, 6575919, 15654334, 8809345, 14073503, 15719357, 10916213, 11312258 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1644055, 7844981, 14322646, 5649236, 2033691, 1444882, 6438493, 3809332 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2822188, 6194522, 14192087, 11369644, 10385821, 5256527, 14396632, 12687551 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5979484, 6915173, 14190302, 10512290, 6369622, 13278652, 7486055, 9855368 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8609915, 5461323, 13996239, 11760565, 10383008, 5316691, 13802965, 9854872 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4137019, 2690851, 15311330, 15119851, 10054040, 14987488, 10711968, 14395863 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4470044, 9269909, 15445733, 13475271, 15254761, 11897787, 12095934, 12029376 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4537371, 6441583, 16434170, 7031148, 3747386, 7888760, 1048592, 4333632 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4140557, 3676207, 14463191, 12489654, 723474, 855831, 394260, 328982 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4138758, 2430991, 4533580, 16240631, 1776917, 1381905, 525323, 1380632 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11836292, 5261616, 1051402, 15775466, 3091231, 1709584, 2301210, 1643286 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6595175, 11265192, 10512028, 5530709, 6787167, 9820555, 5203525, 8106350 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5669982, 12119216, 13141704, 2040605, 2965793, 5073220, 989703, 2636323 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1847830, 9952148, 13467859, 3021096, 1906711, 2963499, 1901848, 2037789 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1315090, 7516528, 14255316, 4661573, 2033691, 1444882, 6438493, 3809332 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2493223, 5734483, 14124757, 10908069, 10385821, 5256527, 14396632, 12687551 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6308705, 7309932, 14257118, 10842023, 6369622, 13278652, 7486055, 9855368 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8807807, 5987667, 14062800, 12024504, 10383008, 5316691, 13802965, 9854872 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4137019, 2888487, 15246562, 15120619, 10054040, 14987488, 10711968, 14395863 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4075285, 8809103, 15444452, 13210818, 15254761, 11897787, 12095934, 12029376 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11990702, 8829302, 5393992, 4808007, 7055968, 5345863, 6266969, 7714415 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 10348954, 4157752, 4533320, 11524012, 11728561, 11597740, 12384954, 11267496 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 7186026, 7972968, 6301526, 7507822, 5278283, 5477453, 5935191, 6529889 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6398052, 11068580, 10116502, 4544070, 6787167, 9820555, 5203525, 8106350 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5735776, 12185009, 13141704, 2106142, 2965793, 5073220, 989703, 2636323 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2308125, 10280345, 13534420, 3745075, 1906711, 2963499, 1901848, 2037789 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1315090, 7582321, 14256340, 5253966, 2033691, 1444882, 6438493, 3809332 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2493223, 5668690, 14124757, 10908069, 10385821, 5256527, 14396632, 12687551 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5979484, 6783843, 14123997, 10314143, 6369622, 13278652, 7486055, 9855368 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6795109, 6258521, 2044451, 11565685, 8366979, 3824443, 4285253, 2044958 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6005849, 6986092, 8232823, 10974066, 8898186, 10279841, 10342303, 7512181 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8504442, 11924919, 9682318, 4138273, 10539660, 9093756, 10933655, 11263905 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2493223, 5800276, 14191062, 11105960, 10385821, 5256527, 14396632, 12687551 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5979484, 6915173, 14124509, 10512290, 6369622, 13278652, 7486055, 9855368 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8609915, 5395530, 13929934, 11562674, 10383008, 5316691, 13737172, 9854872 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4470044, 9204116, 15445733, 13475271, 15123175, 11897787, 12030141, 11897790 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4142612, 6046569, 16433658, 6635878, 3747386, 7888760, 1048592, 4333632 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4140557, 3676207, 14397398, 12358068, 723474, 855831, 394260, 328982 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4140557, 3412779, 14396886, 12160177, 723474, 855831, 394260, 328982 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4138758, 2102026, 4072773, 16240119, 1776917, 1381905, 525323, 1380632 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 7383149, 8235629, 6631004, 7968116, 5278283, 5477453, 5935191, 6529889 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5407323, 11988142, 13009606, 1251089, 2965793, 5073220, 989703, 2636323 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1847830, 9886611, 13401554, 2494496, 1906711, 2963499, 1901848, 2037789 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2888237, 6260316, 14257879, 11369900, 10385821, 5256527, 14396632, 12687551 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5979484, 6980966, 14059228, 10578339, 6369622, 13278652, 7486055, 9855368 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8609915, 5527117, 13930703, 11826613, 10383008, 5316691, 13737172, 9854872 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4137019, 2625058, 15311330, 15119851, 10054040, 14987488, 10711968, 14395863 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 9826727, 11729074, 2901291, 2828070, 6132821, 8170864, 9487494, 8038765 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11925165, 8566898, 4933442, 4150590, 7055968, 5345863, 6266969, 7714415 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 7186026, 7907175, 6037842, 7179112, 5278283, 5477453, 5935191, 6529889 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1847830, 9952148, 13467858, 3152938, 1906711, 2963499, 1901848, 2037789 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1315090, 7450991, 14255316, 4661573, 2033691, 1444882, 6438493, 3809332 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11531180, 5203794, 2500381, 7616563, 600335, 726536, 1714201, 1842451 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5808726, 6657639, 7969906, 10710123, 8898186, 10279841, 10342303, 7512181 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 9695653, 11532719, 2046494, 1577746, 6132821, 8170864, 9487494, 8038765 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 12056239, 8960888, 5394249, 4873800, 7055968, 5345863, 6266969, 7714415 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 10348954, 4223289, 4599370, 11524012, 11728561, 11597740, 12384954, 11267496 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 7186026, 7972969, 6367319, 7639151, 5278283, 5477453, 5935191, 6529889 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6398052, 11068580, 10116246, 4544070, 6787167, 9820555, 5203525, 8106350 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5407323, 11922605, 12943045, 658952, 2965793, 5073220, 989703, 2636323 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 3889462, 8281953, 14458276, 16695486, 1116936, 1117195, 3023647, 2102548 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2186286, 2039322, 10908795, 16697806, 2496018, 2365974, 5584952, 6507083 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 7521148, 1188373, 3546396, 11630959, 2168335, 1574148, 1968133, 2887439 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11465643, 4677963, 1579278, 6825505, 600335, 726536, 1714201, 1842451 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6598242, 5798482, 1123605, 11169385, 8366979, 3824443, 4285253, 2044958 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6136923, 7117678, 8298359, 11039602, 8898186, 10279841, 10342303, 7512181 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8504442, 11924663, 9682063, 4335652, 10539660, 9093756, 10933655, 11263905 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 9695653, 11598000, 2506789, 2301470, 6132821, 8170864, 9487494, 8038765 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 9695653, 11532719, 1980701, 1577746, 6132821, 8170864, 9487494, 8038765 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11925165, 8501104, 4604476, 3690294, 7055968, 5345863, 6266969, 7714415 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11768974, 6313552, 10581881, 6042423, 13998994, 16367283, 12157309, 12288379 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2366485, 9201244, 5316895, 10314846, 5711913, 10644072, 8080723, 10446955 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2372898, 15778242, 10050663, 14920111, 2363658, 3019274, 1771521, 3347726 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 3626546, 7952474, 14391199, 16759737, 1116936, 1117195, 3023647, 2102548 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 7783552, 1911839, 4072997, 11894902, 2168335, 1574148, 1968133, 2887439 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 7521148, 1319959, 3612446, 11696752, 2168335, 1574148, 1968133, 2887439 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11465643, 4875085, 2105366, 7286827, 600335, 726536, 1714201, 1842451 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6598242, 5732689, 1057812, 11169385, 8366979, 3824443, 4285253, 2044958 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5808726, 6526309, 7706990, 10511973, 8898186, 10279841, 10342303, 7512181 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2304559, 8299713, 8079685, 3288110, 67855, 1583154, 922386, 1187618 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1903891, 7307932, 15383738, 8676452, 857868, 857871, 1186314, 792072 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5389888, 5066090, 16765393, 15642799, 8085077, 2759443, 9598314, 4010274 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 15515319, 7169391, 16303808, 8469570, 16764103, 16305350, 13866648, 13869729 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11702924, 5853000, 10186609, 5054501, 13998994, 16367283, 12157309, 12288379 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2761500, 9530723, 5777960, 10579046, 5711913, 10644072, 8080723, 10446955 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2372898, 15712706, 10050920, 14920111, 2363658, 3019274, 1771521, 3347726 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 3626546, 8018524, 14391970, 16694972, 1116936, 1117195, 3023647, 2102548 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 3626546, 7886681, 14391199, 16759737, 1116936, 1117195, 3023647, 2102548 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1857833, 1315342, 10578803, 16762314, 2496018, 2365974, 5584952, 6507083 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4075285, 8743310, 15444452, 13210818, 15123175, 11897787, 12030141, 11897790 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5407323, 11922605, 12943301, 658952, 2965793, 5073220, 989703, 2636323 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2493223, 5865813, 14125781, 11106216, 10385821, 5256527, 14396632, 12687551 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5979484, 6783843, 14058204, 10314143, 6369622, 13278652, 7486055, 9855368 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11925165, 8501105, 4670269, 3690294, 7055968, 5345863, 6266969, 7714415 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 10545565, 4683584, 4994384, 11720880, 11728561, 11597740, 12384954, 11267496 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 7448686, 8367215, 6696796, 7968117, 5278283, 5477453, 5935191, 6529889 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6398052, 11133861, 10314393, 5135695, 6787167, 9820555, 5203525, 8106350 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11465643, 4743756, 1974036, 7220777, 600335, 726536, 1714201, 1842451 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8701310, 12121530, 9944978, 4862253, 10539660, 9093756, 10933655, 11263905 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11925165, 8632178, 4999491, 4347712, 7055968, 5345863, 6266969, 7714415 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 10348954, 3960629, 4138563, 11327145, 11728561, 11597740, 12384954, 11267496 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2695450, 9464674, 5712167, 10579045, 5711913, 10644072, 8080723, 10446955 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 3626546, 8018267, 14457506, 16760508, 1116936, 1117195, 3023647, 2102548 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1857833, 1381135, 10579060, 16762314, 2496018, 2365974, 5584952, 6507083 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11596717, 5269844, 2566174, 7682356, 600335, 726536, 1714201, 1842451 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6598242, 5929812, 1649693, 11367792, 8366979, 3824443, 4285253, 2044958 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 15515319, 7235184, 16304066, 8733513, 16764103, 16305350, 13866648, 13869729 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2366485, 9135451, 5053209, 10051160, 5711913, 10644072, 8080723, 10446955 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2767656, 15779013, 10248813, 14986674, 2363658, 3019274, 1771521, 3347726 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1857833, 1644307, 10776696, 16697292, 2496018, 2365974, 5584952, 6507083 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 7521148, 990994, 3151381, 11433065, 2168335, 1574148, 1968133, 2887439 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6195617, 7514817, 10641765, 6912901, 9813453, 4551300, 10930647, 6786718 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6454163, 9944029, 10647153, 4871002, 11850731, 11983348, 6322827, 10205133 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 3361367, 9025498, 5779750, 1844000, 3492949, 7508384, 2502196, 3821144 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1574926, 6913432, 15382710, 8017750, 857868, 857871, 1186314, 792072 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5719110, 5592432, 16700114, 15643827, 8085077, 2759443, 9598314, 4010274 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 15515833, 7630198, 16239043, 9129298, 16764103, 16305350, 13866648, 13869729 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 11702924, 5984587, 10384245, 5581359, 13998994, 16367283, 12157309, 12288379 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2366485, 9267037, 5382688, 10315359, 5711913, 10644072, 8080723, 10446955 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2366485, 9135194, 4987416, 10051160, 5711913, 10644072, 8080723, 10446955 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 10076370, 12640750, 3884623, 3616809, 4681093, 5798289, 6392481, 8430522 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 12311292, 11853811, 4537144, 4737873, 12642303, 8628671, 11326954, 11326441 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 12245756, 11722740, 4076592, 4145736, 12642303, 8628671, 11326954, 11326441 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8039880, 8630473, 5257013, 7700623, 4748679, 10932966, 4155255, 7511213 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5998495, 7120831, 10246236, 5992315, 9813453, 4551300, 10930647, 6786718 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6585492, 10010079, 10712690, 4871002, 11850731, 11983348, 6322827, 10205133 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 3755868, 9419484, 6175022, 2633516, 3492949, 7508384, 2502196, 3821144 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 2435888, 8365506, 8145477, 3353903, 67855, 1583154, 922386, 1187618 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1975594, 8036799, 7881791, 2761766, 67855, 1583154, 922386, 1187618 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1574926, 7044761, 15317688, 8412765, 857868, 857871, 1186314, 792072 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5389888, 4934504, 16765136, 15576492, 8085077, 2759443, 9598314, 4010274 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 12509182, 3885132, 1776658, 15264443, 2046023, 1973787, 1451048, 1775371 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 14086653, 10270919, 2240047, 12105104, 4609379, 5069413, 2041391, 1844008 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 9416394, 11724796, 4940147, 3882784, 3886941, 5464686, 1845044, 2500915 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5076353, 11656685, 8687266, 4999989, 4086897, 3493729, 8888503, 4215911 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 9945041, 12509679, 3095364, 2432277, 4681093, 5798289, 6392481, 8430522 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 12377084, 11919604, 4537400, 4803666, 12642303, 8628671, 11326954, 11326441 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8302537, 9024460, 5717821, 8161172, 4748679, 10932966, 4155255, 7511213 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5998495, 7252159, 10444129, 6518145, 9813453, 4551300, 10930647, 6786718 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6256785, 9746908, 10515053, 4410451, 11850731, 11983348, 6322827, 10205133 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6256785, 9615837, 10317160, 3752779, 11850731, 11983348, 6322827, 10205133 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4810615, 12960416, 8882268, 13487521, 7894349, 9735519, 14210214, 15921860 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8760007, 2104068, 8092253, 9343069, 790789, 2895128, 6250571, 11447695 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 10667737, 2828832, 3946272, 10856044, 2105623, 1184007, 1315328, 1051904 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 12443646, 3293252, 789763, 15198645, 2046023, 1973787, 1451048, 1775371 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 14086653, 10008005, 1319202, 11710342, 4609379, 5069413, 2041391, 1844008 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 9613515, 11921660, 5400440, 4540972, 3886941, 5464686, 1845044, 2500915 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5405060, 11853806, 9015973, 5592128, 4086897, 3493729, 8888503, 4215911 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 5076353, 11656428, 8753058, 5131575, 4086897, 3493729, 8888503, 4215911 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 9945041, 12509422, 3555658, 3090464, 4681093, 5798289, 6392481, 8430522 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 12245756, 11657204, 3681834, 3619649, 12642303, 8628671, 11326954, 11326441 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 6842685, 8812130, 7498034, 11516784, 15328196, 5985854, 15525828, 7235918 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 13949348, 6049859, 13157518, 15527092, 6974769, 14343844, 9343571, 15462831 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4738097, 4406811, 15263656, 16250817, 16513999, 12698514, 12105605, 9342301 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 1843239, 7697489, 15065500, 15133088, 8355403, 9671263, 14078883, 10328430 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 4547700, 12828828, 8421714, 13224345, 7894349, 9735519, 14210214, 15921860 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8760007, 1972482, 7894873, 9014359, 790789, 2895128, 6250571, 11447695 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 8957128, 2761999, 8421219, 9672293, 790789, 2895128, 6250571, 11447695 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 10667737, 2894626, 4012065, 10921837, 2105623, 1184007, 1315328, 1051904 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 12443646, 3490631, 1316107, 15198648, 2046023, 1973787, 1451048, 1775371 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 14086653, 10073797, 1845289, 11907980, 4609379, 5069413, 2041391, 1844008 }, GemColor.Hypercube, GemType.Hypercube);
            AddSignature(new int[] { 14086653, 10008005, 1253409, 11710342, 4609379, 5069413, 2041391, 1844008 }, GemColor.Hypercube, GemType.Hypercube);

            // Data for HYPERCUBE

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

        public static Gem Get(int[] arr)
        {
            return Get(new Signature(arr));
        }

        private static readonly Random RNG = new Random();
        public static Gem Get(Signature sig)
        {
            Gem gem;
            if (_map.TryGetValue(sig, out gem))
            {
                return gem;
            }

            // If only exact matches are accepted, can save some energy here by returning early.
            if (TOLERANCE <= 0)
            {
                return Gem.Get(GemColor.None, GemType.None);
            }

            List<Gem> matches = new List<Gem>();
            foreach (KeyValuePair<Signature, Gem> kvp in _map)
            {
                if (sig.CompareWithinTolerance(kvp.Key, TOLERANCE, MAX_MISMATCHES))
                {
                    matches.Add(kvp.Value);
                }
            }

            if (matches.Count == 0)
            {
                return Gem.Get(GemColor.None, GemType.None);
            }

            for (int i = 1; i < matches.Count; ++i)
            {
                if (matches[i].Color != matches[0].Color)
                {
#if DEBUG
                    throw new InvalidOperationException("Multiple color matches for the same signature.");
#else
                    return Gem.Get(GemColor.None, GemType.None);
#endif
                }
            }
            return matches[RNG.Next(matches.Count)];    // it isn't kind of great to determine the gem type by choosing randomly

            //else if (matches.Count == 1)
            //{
            //    return matches[0];
            //}
            //else if (matches.Count == 2 && matches[0].Color == matches[1].Color && ((matches[0].Type == GemType.Basic && matches[1].Type == GemType.Fire) || (matches[0].Type == GemType.Fire && matches[1].Type == GemType.Basic)))
            //{
            //    // special case for Blazing Speed
            //    return Gem.Get(matches[0].Color, GemType.Basic);
            //}
            //else
            //{
            //    throw new InvalidOperationException("Multiple matches for the same signature.");
            //}
        }
    }
}
