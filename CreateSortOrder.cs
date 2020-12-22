using System.Collections.Generic;

namespace Auto_Sort {
    public static class CreateSortOrder {
        public static Dictionary<string, int> Get() {
            var itemSortOrders = new Dictionary<string, int>();

            var i = -1;

            // Guns'n'ammo
            itemSortOrders.Add("Revolver::e29b47f8c6c51304fa6a6de445d0990d", ++i);
            itemSortOrders.Add("Revolver ammo::25ef235fa1e492441844c9fc34f5cb47", ++i);
            itemSortOrders.Add("Revolver high-power ammo::55468dc2f73c108439216ba9093c549e", ++i);
            itemSortOrders.Add("Explosive revolver ammo::94b9be8c248e72048ba0618864aa0611", ++i);

            itemSortOrders.Add("Shotgun::40870ff1f1c5f6648beabf356d296a5b", ++i);
            itemSortOrders.Add("Buckshot::c7b01a0232ae53e478f0b4b92031c416", ++i);
            itemSortOrders.Add("Slugs::84fdc501781979841a5e78d3a4bdfe03", ++i);
            itemSortOrders.Add("AP Slugs::6b328e39137971946aec0befbd285190", ++i);

            itemSortOrders.Add("SMG::96048d612ab1ea246b50745a12b9b05e", ++i);
            itemSortOrders.Add("SMG Ammo::c7f58533040c3c646b6ea331e8dd0e76", ++i);
            itemSortOrders.Add("SMG Ammo T2::52c87180c4ed42c40903a92b40b127f5", ++i);

            itemSortOrders.Add("Sniper::75416daac1a28094bb7b6d8f2d690c99", ++i);
            itemSortOrders.Add("Sniper Ammo::ee1e9c8eb67fd2544982afda0ee6dcf2", ++i);

            itemSortOrders.Add("Hand mortar::da137d36a12c54e46b3a132180b98bb1", ++i);
            itemSortOrders.Add("Mortar grenade::721881fe35216b3468df695b3d23acda", ++i);
            itemSortOrders.Add("High-explosive mortar grenade::57337a97eb81c7f4ab9f355ddc0d8fdc", ++i);

            itemSortOrders.Add("Gatling gun::0670120db8e3ade4ba19a1928b19ce3d", ++i);
            itemSortOrders.Add("Gatling ammo::0c215781eafd06a4ead9810f8800e13a", ++i);

            // Tools
            itemSortOrders.Add("Hacking tool::a8be95e4cba7ba844821734d0780d719", ++i);
            itemSortOrders.Add("Revive Tool::3fbc57594592bee4ca5f261484b635b5", ++i);

            itemSortOrders.Add("Detonator::a2e86f35475b1294191575f698729f17", ++i);
            itemSortOrders.Add("Explosive::3b65509dc93e8bf4cbfb39454080f4f6", ++i);

            itemSortOrders.Add("Grenade::850bf93472186b54d8ebfd87223989db", ++i);

            itemSortOrders.Add("Medkit::7dc960ed2a495bc41a29d47359dcbf37", ++i);

            // Armor
            itemSortOrders.Add("Copper Armor Kit::e7111feccf1d6e649963eac87fddf20d", ++i);
            itemSortOrders.Add("Iron Armor Kit::13eb8795a0adb4e499377fcf8102894c", ++i);
            itemSortOrders.Add("Titanium Armor Kit::02bd8b0bf0c7cf840a61f910289c882c", ++i);

            // Repair
            itemSortOrders.Add("Module repair kit::1bf6d40a49d9e2148a2d2389a768f15f", ++i);
            itemSortOrders.Add("Breach replacement::2f88af3168900fd47aca22d25bdf3db6", ++i);

            // Destroyed Modules
            itemSortOrders.Add("Destroyed production module T1::58d09ebd1461f0d499578d175c40b664", ++i);
            itemSortOrders.Add("Destroyed production module T2::ff1f3d34d8c71574b944598d351c8815", ++i);
            itemSortOrders.Add("Destroyed production module T3::30e40c645683d9e47a14c2ef013ae3d6", ++i);
            itemSortOrders.Add("Destroyed refinery module T1::6e429490a8b23c1479001cf5a8261f84", ++i);
            itemSortOrders.Add("Destroyed refinery module T2::2b8e38028da543c43829be235e625ca1", ++i);
            itemSortOrders.Add("Destroyed refinery module T3::dae2caa1449bffb44971307eadccb2f1", ++i);
            itemSortOrders.Add("Destroyed research module T1::ac7f7c6ededd3d748bc2fb595b68f561", ++i);
            itemSortOrders.Add("Destroyed research module T2::e5be8b01d82e370439f481d4a4e148d7", ++i);
            itemSortOrders.Add("Destroyed research module T3::0c496107eadb88343b5fe35ebbf3a4c5", ++i);

            // Heads
            itemSortOrders.Add("Builder head::a8a2e7eb3c5146f4ebf8970607b37c52", ++i);
            itemSortOrders.Add("Technician head::0af47bdf33b44ed40a527cdde8da0514", ++i);
            itemSortOrders.Add("Engineer head::cafc4d008b3688c4e957f9404c45ebaa", ++i);
            itemSortOrders.Add("Miner head::3ad5b5d8f1c0c0f4d82e85fc56707653", ++i);
            itemSortOrders.Add("Foundryman head::f1a2dd04063a9944fa5b0236bb11bbdd", ++i);
            itemSortOrders.Add("Metallurgist head::8604f46bc1ad6104d830abe85a07a0dd", ++i);
            itemSortOrders.Add("Explorer head::087f8c24f97b6ea43a1921d9cb6ae239", ++i);
            itemSortOrders.Add("Chemist head::72a2dbe3afc8f384d9eb7472bd667d2f", ++i);
            itemSortOrders.Add("Scientist head::64d149d6ac860ae45b519da20f325743", ++i);

            // Intel
            itemSortOrders.Add("Intel production T1::2910c00231f76c646a01684dd078f24a", ++i);
            itemSortOrders.Add("Intel production T2::8550516dc00b41e448a35d9246b71960", ++i);
            itemSortOrders.Add("Intel production T3::de49e8a2a5685b34e9cbd556749296f8", ++i);
            itemSortOrders.Add("Intel refinery T1::c5703a9caa05f054885f1c55e690cac8", ++i);
            itemSortOrders.Add("Intel refinery T2::d65ca4042608a104d87d9cfdde660ffc", ++i);
            itemSortOrders.Add("Intel refinery T3::8194be0ee20cc9b47b4bc7b97345a9a3", ++i);
            itemSortOrders.Add("Intel research T1::c835155f54e5a474c96746e6bfe0ecfa", ++i);
            itemSortOrders.Add("Intel research T2::8954ad7e13dff954caf1264906cbf48e", ++i);
            itemSortOrders.Add("Intel research T3::397238c7f2ba2c2498a97c731ebf3c75", ++i);

            // Cores
            itemSortOrders.Add("Drillship core 1::831fffcfc9687254abc725a140675467", ++i);
            itemSortOrders.Add("Drillship core 2::3d8201489a2dd1146b53543aadcfe418", ++i);
            itemSortOrders.Add("Drillship core 3::0bf8f15db1616fc49a8965909fc56e33", ++i);

            // Engines
            itemSortOrders.Add("Engine 2::ee7643bb8c3975640abff628bde9a9b7", ++i);
            itemSortOrders.Add("Engine 3::c01f451074ac3d04795d74be4e06fe91", ++i);

            // Segment
            itemSortOrders.Add("Drillship segment::fd952475c91a3904fb3c5688b087be8a", ++i);

            // Drill
            itemSortOrders.Add("Hardened drill parts::cf1c0539d62990044a9b67688e898abf", ++i);
            itemSortOrders.Add("Hardened drill::a11806d071ae24c40b3de46aa4ed3bc3", ++i);
            itemSortOrders.Add("Corundum drill parts::0032bca7659e9e9459a465c50d3b6fbb", ++i);
            itemSortOrders.Add("Corundum drill::a41d6125f2945fd4cbadafa46df09bf0", ++i);
            itemSortOrders.Add("Diamond drill parts::d0b18a9fc5574b74c9b6df4e93d8eb20", ++i);
            itemSortOrders.Add("Diamond drill::130ff88e8664e3442ad12caea6fd7400", ++i);

            // Tread
            itemSortOrders.Add("Modified tracks parts::ff9a9b57602c4e6458f9c01dd8ecfa65", ++i);
            itemSortOrders.Add("Modified tracks::e1b4ffe7c3b0fe44db9d60f68b2a6340", ++i);
            itemSortOrders.Add("Improved tracks parts::be9ebd35950d57745ba1f3fdc76fd25c", ++i);
            itemSortOrders.Add("Improved tracks::3d937f4e86280e1428510afd3dd70104", ++i);
            itemSortOrders.Add("Advanced tracks parts::ee866e83908cae24994ce5c17656a6d8", ++i);
            itemSortOrders.Add("Advanced tracks::c83d9a64b6f93f24b90578a3161f8df6", ++i);

            // Hull
            itemSortOrders.Add("Reinforced hull parts::54c206b89b5398f41a671b6f3a11a4a4", ++i);
            itemSortOrders.Add("Reinforced hull::d62e229c21b37dd429559bd9b8728d84", ++i);
            itemSortOrders.Add("Steel hull parts::efb34100e06bea247b15a978a5237cc2", ++i);
            itemSortOrders.Add("Steel hull::cac9c2f73bda1c04aac37c4a1cf89ce3", ++i);
            itemSortOrders.Add("Titanium hull parts::f8cbf5d16b1a4a74e9cc30a152482648", ++i);
            itemSortOrders.Add("Titanium hull::904434a1cb2d03846a9c26d568a54920", ++i);

            // Prod Schem
            itemSortOrders.Add("Production Tier 1 Schematics::e9e152422201c3e4989ff113e13bfa84", ++i);
            itemSortOrders.Add("Upgrade basic production::1b3d424506d823f4d859a78655997cfb", ++i);
            itemSortOrders.Add("Upgrade advanced production::c961d56fd4ca7c644abcb029eec8b993", ++i);

            // Ref Schem
            itemSortOrders.Add("Refining Tier 1 Schematics::cf7a13488f08f934185bd003b89c23f0", ++i);
            itemSortOrders.Add("Upgrade basic refinery::e6a3240191e18654fb22c183c8cfdffd", ++i);
            itemSortOrders.Add("Upgrade advanced refinery::2bd7b88db440ddf40b2032fc3843579b", ++i);

            // Sci Schem
            itemSortOrders.Add("Research Tier 1 Schematics::faad87a6f6f69f642afc7af9bd2196a0", ++i);
            itemSortOrders.Add("Upgrade basic research::d095455c4b4555749bc3387b0204d35e", ++i);
            itemSortOrders.Add("Upgrade advanced research::159e6147774427e48944028e31867280", ++i);

            // Exp Schem
            itemSortOrders.Add("Simple Explosives::5f8cd9632a5663443927c5cf09c210d9", ++i);
            itemSortOrders.Add("Improved Explosives::22af3ac761869484fa0b7acf735b5318", ++i);
            itemSortOrders.Add("Advanced Explosives::49e4b97fd5b3e7c40b8702fb1a662ed9", ++i);
            itemSortOrders.Add("Starter Structures Schematic::2bfc828dc9788d645a221a53dbd4e1b8", ++i);
            itemSortOrders.Add("Improved Structures Schematic::cd9ae09a9822fe146ad880607f3f0e69", ++i);

            // Coal
            itemSortOrders.Add("Coal::e89c0cdbf40a07f4ebb20d2865717a52", ++i);

            // Ores
            itemSortOrders.Add("Copper ore::d1c5ccba9f65302408be2e46975020e7", ++i);
            itemSortOrders.Add("Copper scrap metal::1389347b3fca5534ba680b05ce1cf476", ++i);
            itemSortOrders.Add("Copper ingot::9386d447191c7aa4fa913943abd75481", ++i);
            itemSortOrders.Add("Iron ore::8184e2f7fbec373469f650ff3febcf99", ++i);
            itemSortOrders.Add("Iron scrap metal::1160b9c0f5386044a819adaa48d26f95", ++i);
            itemSortOrders.Add("Iron ingot::f74e4356dcd38b7418a666b63c0304b1", ++i);
            itemSortOrders.Add("Titanium Ore::3d4fce1d9e298384ea12a6e66fa92ba2", ++i);
            itemSortOrders.Add("Titanium Scrap Metal::5abe2a64bf3553f4da476f43f31eb7e5", ++i);
            itemSortOrders.Add("Titanium ingot::c3d1b45a69512824fbade5378c5a4a52", ++i);

            // Alloys
            itemSortOrders.Add("Alloy T1 ingot::8cbb0001e180fe241b3da6ef1018b3df", ++i);
            itemSortOrders.Add("Alloy T2 ingot::7d475c9d18e267f41b82f736ed19a194", ++i);
            itemSortOrders.Add("Alloy T3 ingot::13fbc577a43e7f34e914b3d8d8832c16", ++i);

            // Secondary Ores
            itemSortOrders.Add("SulfurOre::9ffb5e60912dc6a4280c317dbdbcab52", ++i);
            itemSortOrders.Add("Sulfur powder::156562c6e6475dd4eb885291a4662a6f", ++i);
            itemSortOrders.Add("Raw Crystals::1846377ac119fd64ab8fd73dccfe0923", ++i);
            itemSortOrders.Add("Crystal::63e5ebe76f201c549b93e73a3be1044a", ++i);
            itemSortOrders.Add("Raw Diamond::98244c77b188a0740a2ba3df0dfab2fe", ++i);
            itemSortOrders.Add("Diamond::7ba2d6c7d6bf2eb41b9732aa1b8f2396", ++i);

            // Intermediaries (Copper)
            itemSortOrders.Add("Copper bolts::ca8ecba733454c8439fdc1c068756eb2", ++i);
            itemSortOrders.Add("Copper plates::8df9c647d90ecaa4e9539cdeb5e3683c", ++i);
            itemSortOrders.Add("Copper tubes::ddf109b40b214a640967e3085841d22d", ++i);
            itemSortOrders.Add("Copper radiator::bafa87209ecbd97428e814d7580860dc", ++i);
            itemSortOrders.Add("Copper wire::46d1d98e93bd44a48a55c9cf5337ee5d", ++i);
            itemSortOrders.Add("Copper Levers::3b42ca843c8036b4087c1584eee1e406", ++i);
            itemSortOrders.Add("Copper gun components::0ee40de42e641e34689855fcd200f82a", ++i);
            itemSortOrders.Add("Copper bullet casings::0a1bdffa1c60d3c429dbf90cc5e9dc41", ++i);

            // Intermediaries (Iron)
            itemSortOrders.Add("Iron bolts::1e67627353287044d80186dc824db14b", ++i);
            itemSortOrders.Add("Iron plates::a4a481934c0d6d743b38e9ea78069267", ++i);
            itemSortOrders.Add("Iron tubes::272d8bc0a4ea1ba4c825db30b840a677", ++i);
            itemSortOrders.Add("Iron frame::327cd2fff4fe89047829617583b96fff", ++i);
            itemSortOrders.Add("Iron gear::ce4da15226d4b4649a2047d48e66d135", ++i);
            itemSortOrders.Add("Iron bullet casings::36564125a959788458eddb0bfda38f2d", ++i);

            // Intermediaries (Titanium)
            itemSortOrders.Add("Titan bolts::53a8f946b466b9e4d90b2544569ba062", ++i);
            itemSortOrders.Add("Titan plates::f878209ee44486c4faaf53d535e39ffc", ++i);
            itemSortOrders.Add("Titan tubes::b3a0b7be95f2ec146a98f25dd98e7f98", ++i);
            itemSortOrders.Add("Titanium bullet casings::b9523c64a5674d148848640c143a4f02", ++i);

            // Intermediaries (Misc)
            itemSortOrders.Add("Black powder::d328101fb2c64b44fbb0e2748a64a037", ++i);
            itemSortOrders.Add("Dials::f4f1eb1effb618444ab53653636ef479", ++i);

            // Turret Ammo
            itemSortOrders.Add("Pistol turret ammo::f46cdfb659dd5f3428f5a1c9c1fe7d32", ++i);
            itemSortOrders.Add("Buckshot::cdd3ca2c103709d4395f67d08bef56f9", ++i);
            itemSortOrders.Add("SMG Ammo::3bd794833a3c801498d50cb745f51734", ++i);
            itemSortOrders.Add("Sniper Ammo::66a6ec9baa4d140438c316b93c639a72", ++i);
            itemSortOrders.Add("Mortar grenade::6af41273ef98e88499f8a7d4e71430c6", ++i);
            itemSortOrders.Add("Gatling ammo::68125db51cd1b714d8cd8f1dd1e1d374", ++i);

            // Prod Devices
            itemSortOrders.Add("Pump::8b608e7646eaa814caaed60576d6ea71", ++i);
            itemSortOrders.Add("Hydraulics::999489237d3e69443b139ccae6be3f2c", ++i);
            itemSortOrders.Add("Transmission::fcf67ebb367355c4795c56c0953b2017", ++i);

            // Ref Devices
            itemSortOrders.Add("Shredder::8ca4bb19538d15349a160e6df2036e1d", ++i);
            itemSortOrders.Add("Boiler::71da14bcfb171a44d9aabdeb79674527", ++i);
            itemSortOrders.Add("Furnace::a6a525934b8ccfc4997674ad830afc9d", ++i);

            // Sci Devices
            itemSortOrders.Add("Converter::13614afd1e1e9ce48b1e152e84c5ae6c", ++i);
            itemSortOrders.Add("Sensors::38b13a4a479a3f043a8b83e81c08d340", ++i);
            itemSortOrders.Add("Analyzer::acadc09e5549c2942b7d57d11dc21f04", ++i);

            // Modules
            itemSortOrders.Add("Coal Powerplant Tier 1::7155d1834822b064a812b57eedb4fcac", ++i);
            itemSortOrders.Add("Coal Powerplant Tier 2::da53182cfeaac444db3c587904eb292f", ++i);
            itemSortOrders.Add("Coal Powerplant Tier 3::25c8f53e03229144f930b125870ef18e", ++i);
            itemSortOrders.Add("Production Tier 1::e88f236cccc6b78488bcd03fcaa61d16", ++i);
            itemSortOrders.Add("Production Tier 2::ba98d563515d93a4f87264883c9e7507", ++i);
            itemSortOrders.Add("Production Tier 3::52d108d86d10cc044bc9503239eba930", ++i);
            itemSortOrders.Add("Refinery Tier 1::72b0b47f1ae773843a62186e24453fb6", ++i);
            itemSortOrders.Add("Refinery Tier 2::2d64396a31c055d43aff151e30ee4cb6", ++i);
            itemSortOrders.Add("Refinery Tier 3::527f1530e12c2f743a6145b62fad4921", ++i);
            itemSortOrders.Add("Research Tier 1::de637c6e60882324e8c4f49a7f322351", ++i);
            itemSortOrders.Add("Research Tier 2::5adf9866c6c484a47a9a2be39f97fa98", ++i);
            itemSortOrders.Add("Research Tier 3::a8841010102dd33438dd76dfa5e5b698", ++i);
            itemSortOrders.Add("Storage Tier 1::38d294f9c4a553d4d947958321966f91", ++i);
            itemSortOrders.Add("Storage Tier 2::b0517105257182f49afcbe23088845de", ++i);
            itemSortOrders.Add("Storage Tier 3::86d7151630e909944991dbedc1998497", ++i);

            // Modules (Turrets)
            itemSortOrders.Add("Turret Module::3bf96763d5dfb564aad936a087cb614e", ++i);
            itemSortOrders.Add("Turret Module Shotgun::6dcf6c5ca3b8f1741af35a4011cdaa1e", ++i);
            itemSortOrders.Add("Turret Module SMG::4912009609358ea46bc2ceac554045e6", ++i);
            itemSortOrders.Add("Turret ModuleSniper::b40d3f9773a3a014c9ce1801b2696538", ++i);
            itemSortOrders.Add("Turret Module Gatling::4b17c7bc9d6c2ee46b7807292f26b432", ++i);
            itemSortOrders.Add("Turret Module Mortar::a2a0d7a9fab7dee4f8b2f7a6d0912b5a", ++i);

            // Doors
            itemSortOrders.Add("Door module::6edc5f9c55fb25c48a63ad047bd38b32", ++i);
            itemSortOrders.Add("Window module::bffddb68717b5fb4fbfd2200ff6158db", ++i);

            // Station, hubs, and all interior devices follow.
            itemSortOrders.Add("Hub production::ca0964a43824b38468eed492d2385ec4", ++i);
            itemSortOrders.Add("Hub refinery::d4446b96f5a46494e8bed91cc40c06b7", ++i);
            itemSortOrders.Add("Hub research::00175574f3d8b8c41b2da96cd19cfc40", ++i);
            itemSortOrders.Add("Hub scrap::b4fbc6dbf6156184383895f886d838bd", ++i);

            itemSortOrders.Add("Production station::7c32d187420152f4da3a79d465cbe87a", ++i);
            itemSortOrders.Add("Refinery station::3b35b8f4f39847945b9881e25bb01f5a", ++i);
            itemSortOrders.Add("Research station::a7764724dfb030a47a531f7c5e87ff9e", ++i);
            itemSortOrders.Add("Scrap station::a28879ce9c7caab40a38781abb6af9ae", ++i);

            itemSortOrders.Add("Worktable::f61e601e773ff884497d265728ceacaa", ++i);
            itemSortOrders.Add("Refinery Worktable::655ac6f1bdb43da4f9ee18c6285b41ff", ++i);
            itemSortOrders.Add("Research Worktable::493fb6e4e66a02a4a8c512e0b94b5414", ++i);

            itemSortOrders.Add("Chest::d273efccf8a1b3b46b35e781da1d7b1e", ++i);

            itemSortOrders.Add("Controller system small::fd74b5cfbeca4f54caba56609b4585cd", ++i);
            itemSortOrders.Add("Controller manufacture small::d1ef00215f1d81e43bccaafd94e3f874", ++i);
            itemSortOrders.Add("Controller System Medium::a9d89fb653b26fc488ad963f756b467b", ++i);
            itemSortOrders.Add("Controller Manufacture Medium::773ceb48d01a9cb41913231634ac4ab8", ++i);
            itemSortOrders.Add("Controller custom::9941cf077a45c034ab0468d1ee7c1442", ++i);
            itemSortOrders.Add("Controller shutdown::ddb88eb052f394446822efd3668fe541", ++i);

            itemSortOrders.Add("Copper door::2f37c2f7701fb8b44abefdcd03681b8b", ++i);
            itemSortOrders.Add("Copper window::54dff72cdbd77b146a34ad3e99a740ed", ++i);
            itemSortOrders.Add("Copper floor hole::412f37021714e0f41acb8cba44b9e296", ++i);
            itemSortOrders.Add("Copper floor::5a7116a700e47a548b217b22de257084", ++i);
            itemSortOrders.Add("Copper ladder::36a6599672ae13f49b0ec42133578d40", ++i);
            itemSortOrders.Add("Copper wall hole::dc63525a705ab88438157d406108d8e9", ++i);
            itemSortOrders.Add("Copper wall::f40af8db8e467ac4ab2fd210ac9f2a6e", ++i);

            itemSortOrders.Add("Display small::f05b55976bda24c4eae5878abab676d9", ++i);
            itemSortOrders.Add("Display medium::8df86ab1bb09cb34d831cd7eaec5e6dd", ++i);
            itemSortOrders.Add("Display large::f54ad55a1555eee4c9e634afc077c4bb", ++i);

            itemSortOrders.Add("Panel core small::160a4eb9bedfae841a3df84aaff9ec29", ++i);
            itemSortOrders.Add("Panel system small::550c35b99061b8b4aaf7bccae8f50cf2", ++i);
            itemSortOrders.Add("Panel manufacture small::cb7f84ebdc80e834dbbedb38851af64a", ++i);
            itemSortOrders.Add("Panel large::2e1f935fcfac51d4a9246f8a0b54438e", ++i);
            itemSortOrders.Add("Panel system medium::48d0935f09556884fa316d94ca00be36", ++i);
            itemSortOrders.Add("Panel manufacture medium::11e7bacd68e5c0e4e90336d993031484", ++i);

            itemSortOrders.Add("Stats panel::7cc4fb82796808145bc0f1fa06cc7607", ++i);
            itemSortOrders.Add("Storage door::4dc894129cceae8459840de3a228985f", ++i);
            itemSortOrders.Add("Periscope::f87de61209b99e440a505d1e00fa1099", ++i);
            itemSortOrders.Add("Pilot seat::4c0e51c601608544fbd2e5a2b50f5bcc", ++i);
            itemSortOrders.Add("Lever stand::6398b069860ade44082f9d7b68e5ffb2", ++i);
            itemSortOrders.Add("Light::2b016a075df938c4a8e20efbdcda209c", ++i);
            itemSortOrders.Add("Long distance radio::2259c7da81d447c4e9920cef56b51a81", ++i);
            itemSortOrders.Add("MapStand::f077e3ec6988bc24dbd443d0b719d792", ++i);
            itemSortOrders.Add("BannerLarge::147bae0548753c047a4848555601fe5f", ++i);
            itemSortOrders.Add("BannerSmall::aa91b28ceaa9e5646b5b4fa451835124", ++i);
            itemSortOrders.Add("Bed::81f42329261e3d948851ae235793ad10", ++i);

            return itemSortOrders;
        }
    }
}