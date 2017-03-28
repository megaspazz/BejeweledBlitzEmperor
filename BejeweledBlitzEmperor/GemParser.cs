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

        public static readonly int TOLERANCE = 2;

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

            // x2 RED
            AddSignature(new int[] { 16777215, 15277613, 16777215, 15658734, 16060704, 16716322, 16519457, 16388385 }, GemColor.Red, GemType.X2);

            // x3 RED
            AddSignature(new int[] { 16777215, 7212565, 16777215, 14540253, 16060704, 14487325, 16519457, 15470623 }, GemColor.Red, GemType.X3);

            // x4 RED
            AddSignature(new int[] { 16777215, 16777215, 16777215, 3474182, 10160660, 5383464, 7735311, 11184810 }, GemColor.Red, GemType.X4);

            // x5 RED
            AddSignature(new int[] { 14736861, 16777215, 14540253, 12303291, 12586265, 13372955, 14683933, 15339551 }, GemColor.Red, GemType.X5);

            // x6 RED
            AddSignature(new int[] { 16777215, 14540253, 16777215, 11184810, 5768715, 16777215, 5834251, 16777215 }, GemColor.Red, GemType.X6);

            // x7 RED
            AddSignature(new int[] { 16777215, 12064548, 16777215, 16777215, 15601695, 16716322, 16388385, 16716322 }, GemColor.Red, GemType.X7);

            #endregion

            #region Green

            // Basic GREEN
            AddSignature(new int[] { 4652653, 7536302, 971812, 256025, 5570184, 5897872, 1091362, 1090593 }, GemColor.Green, GemType.Basic);

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
            AddSignature(new int[] { 16777215, 246544, 16777215, 15658734, 48140, 50189, 49676, 49420 }, GemColor.Green, GemType.X2);

            // x3 GREEN
            AddSignature(new int[] { 16777215, 89095, 16777215, 14540253, 48140, 43275, 49676, 46604 }, GemColor.Green, GemType.X3);

            // x4 GREEN
            AddSignature(new int[] { 16777215, 16777215, 16777215, 10498, 30471, 2246436, 23302, 11184810 }, GemColor.Green, GemType.X4);

            // x5 GREEN
            AddSignature(new int[] { 14541021, 16777215, 14540253, 12303291, 37641, 39946, 44299, 46091 }, GemColor.Green, GemType.X5);

            // x6 GREEN
            AddSignature(new int[] { 16777215, 14540253, 16777215, 11184810, 17412, 16777215, 17668, 16777215 }, GemColor.Green, GemType.X6);

            // x7 GREEN
            AddSignature(new int[] { 16777215, 170509, 16777215, 16777215, 46604, 50189, 49420, 50445 }, GemColor.Green, GemType.X7);

            // x8 GREEN
            AddSignature(new int[] { 16777215, 7829367, 16777215, 6710886, 35849, 16644, 32264, 5598294 }, GemColor.Green, GemType.X8);

            #endregion

            #region Blue

            // Basic BLUE
            AddSignature(new int[] { 1670908, 12689, 611787, 40702, 1214204, 1213949, 1150206, 1084414 }, GemColor.Blue, GemType.Basic);

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
            AddSignature(new int[] { 16777215, 3511785, 16777215, 15658734, 2791157, 2924031, 2857980, 2857466 }, GemColor.Blue, GemType.X2);

            // x3 BLUE
            AddSignature(new int[] { 16777215, 1656686, 16777215, 14540253, 2791157, 2525405, 2857980, 2658796 }, GemColor.Blue, GemType.X3);

            // x4 BLUE
            AddSignature(new int[] { 16777215, 16777215, 16777215, 598069, 1728411, 2768978, 1329270, 11184810 }, GemColor.Blue, GemType.X4);

            // x5 BLUE
            AddSignature(new int[] { 14540768, 16777215, 14540253, 12303291, 2193088, 2325964, 2525664, 2658538 }, GemColor.Blue, GemType.X5);

            // x6 BLUE

            // x7 BLUE
            AddSignature(new int[] { 16777215, 2782904, 16777215, 16777215, 2724590, 2924031, 2857466, 2924031 }, GemColor.Blue, GemType.X7);

            // x8 BLUE
            AddSignature(new int[] { 16777215, 7829367, 16777215, 6710886, 2060470, 930900, 1861028, 5924722 }, GemColor.Blue, GemType.X8);

            #endregion

            #region Yellow

            // Basic YELLOW
            AddSignature(new int[] { 16695311, 16711238, 16711213, 14388480, 16710437, 16710180, 16709156, 16708899 }, GemColor.Yellow, GemType.Basic);

            // Coin YELLOW
            AddSignature(new int[] { 10316319, 16775978, 16117553, 16777013, 16513092, 13148972, 15852585, 13939757 }, GemColor.Yellow, GemType.Coin);

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
            AddSignature(new int[] { 16777215, 15328521, 16777215, 15658734, 15657472, 16315392, 16118016, 15986432 }, GemColor.Yellow, GemType.X2);

            // x3 YELLOW
            AddSignature(new int[] { 16777215, 7236612, 16777215, 14540253, 15657472, 14144256, 16118016, 15065344 }, GemColor.Yellow, GemType.X3);

            // x4 YELLOW
            AddSignature(new int[] { 16777215, 16777215, 16777215, 3420928, 9933824, 5328930, 7565568, 11184810 }, GemColor.Yellow, GemType.X4);

            // x5 YELLOW
            AddSignature(new int[] { 14737629, 16777215, 14540253, 12303291, 12236544, 13026048, 14276096, 14933760 }, GemColor.Yellow, GemType.X5);

            // x6 YELLOW
            AddSignature(new int[] { 16777215, 14540253, 16777215, 11184810, 5657600, 16777215, 5723392, 16777215 }, GemColor.Yellow, GemType.X6);

            // x7 YELLOW
            AddSignature(new int[] { 16777215, 12104967, 16777215, 16777215, 15196928, 16315392, 15986432, 16315392 }, GemColor.Yellow, GemType.X7);

            #endregion

            #region Purple

            // Basic PURPLE
            AddSignature(new int[] { 10027161, 16694782, 16061941, 14356187, 16126198, 15994612, 15798257, 15667183 }, GemColor.Purple, GemType.Basic);

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
            AddSignature(new int[] { 16777215, 13377483, 16777215, 15658734, 13898451, 14488540, 14291673, 14160599 }, GemColor.Purple, GemType.X2);

            // x3 PURPLE
            AddSignature(new int[] { 16777215, 6360672, 16777215, 14540253, 13898451, 12521662, 14291673, 13373899 }, GemColor.Purple, GemType.X3);

            // x4 PURPLE
            AddSignature(new int[] { 16777215, 16777215, 16777215, 3015725, 8784774, 4990284, 6686822, 11184810 }, GemColor.Purple, GemType.X4);

            // x5 PURPLE
            AddSignature(new int[] { 14736864, 16777215, 14540253, 12303291, 10882725, 11538352, 12718273, 13242825 }, GemColor.Purple, GemType.X5);

            // x6 PURPLE
            AddSignature(new int[] { 16777215, 14540253, 16777215, 11184810, 4982348, 16777215, 5047885, 16777215 }, GemColor.Purple, GemType.X6);

            // x7 PURPLE
            AddSignature(new int[] { 16777215, 10557601, 16777215, 16777215, 13504973, 14488540, 14160599, 14488540 }, GemColor.Purple, GemType.X7);

            // x8 PURPLE

            #endregion

            #region Orange

            // Basic ORANGE
            AddSignature(new int[] { 16706670, 16711316, 16678942, 16675341, 16710521, 16710782, 15362338, 15099169 }, GemColor.Orange, GemType.Basic);

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
            AddSignature(new int[] { 16777215, 15301941, 16777215, 15658734, 16087594, 16744236, 16547115, 16415787 }, GemColor.Orange, GemType.X2);

            // x3 ORANGE
            AddSignature(new int[] { 16777215, 7224089, 16777215, 14540253, 16087594, 14511654, 16547115, 15496488 }, GemColor.Orange, GemType.X3);

            // x4 ORANGE
            AddSignature(new int[] { 16777215, 16777215, 16777215, 3480073, 10177818, 5388842, 7748372, 11184810 }, GemColor.Orange, GemType.X4);

            // x5 ORANGE
            AddSignature(new int[] { 14737373, 16777215, 14540253, 12303291, 12607265, 13395235, 14708518, 15365160 }, GemColor.Orange, GemType.X5);

            // x6 ORANGE
            AddSignature(new int[] { 16777215, 14540253, 16777215, 11184810, 5778447, 16777215, 5843983, 16777215 }, GemColor.Orange, GemType.X6);

            // x7 ORANGE
            AddSignature(new int[] { 16777215, 12084010, 16777215, 16777215, 15627817, 16744236, 16415787, 16744236 }, GemColor.Orange, GemType.X7);

            // x8 ORANGE

            #endregion

            #region White

            // Basic WHITE
            AddSignature(new int[] { 16711422, 16514043, 10855845, 14474460, 16711422, 16711422, 15198183, 14737632 }, GemColor.White, GemType.Basic);

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
            AddSignature(new int[] { 16777215, 13158600, 16777215, 15658734, 13487565, 14079702, 13882323, 13750737 }, GemColor.White, GemType.X2);

            // x3 WHITE
            AddSignature(new int[] { 16777215, 6184542, 16777215, 14540253, 13487565, 12171705, 13882323, 13027014 }, GemColor.White, GemType.X3);

            // x4 WHITE
            AddSignature(new int[] { 16777215, 16777215, 16777215, 2894892, 8553090, 4868682, 6513507, 11184810 }, GemColor.White, GemType.X4);

            // x5 WHITE
            AddSignature(new int[] { 14737632, 16777215, 14540253, 12303291, 10592673, 11250603, 12369084, 12895428 }, GemColor.White, GemType.X5);

            // x6 WHITE
            AddSignature(new int[] { 16777215, 14540253, 16777215, 11184810, 4868682, 16777215, 4934475, 16777215 }, GemColor.White, GemType.X6);

            // x7 WHITE

            // x8 WHITE
            AddSignature(new int[] { 16777215, 7829367, 16777215, 6710886, 10000536, 4671303, 9013641, 7237230 }, GemColor.White, GemType.X8);


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
                if (sig.CompareWithinTolerance(kvp.Key, TOLERANCE))
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
                    throw new InvalidOperationException("Multiple color matches for the same signature.");
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
