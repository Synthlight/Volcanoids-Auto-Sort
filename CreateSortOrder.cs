﻿using System.Collections.Generic;

namespace Auto_Sort;

public static class CreateSortOrder {
    public static Dictionary<Item, int> Get() {
        var itemSortOrders = new Dictionary<Item, int>();

        var i = -1;

        itemSortOrders.Add(new("c88c68b3fc481bf44830246bc880d3aa", "Wrench"), ++i);

        // Guns'n'ammo
        itemSortOrders.Add(new("e29b47f8c6c51304fa6a6de445d0990d", "Revolver"), ++i);
        itemSortOrders.Add(new("7b675e7db68003a4e9dc81bdd9cb7d01", "Revolver"), ++i);
        itemSortOrders.Add(new("25ef235fa1e492441844c9fc34f5cb47", "Revolver ammo"), ++i);
        itemSortOrders.Add(new("55468dc2f73c108439216ba9093c549e", "Revolver high-power ammo"), ++i);
        itemSortOrders.Add(new("94b9be8c248e72048ba0618864aa0611", "Explosive revolver ammo"), ++i);

        itemSortOrders.Add(new("40870ff1f1c5f6648beabf356d296a5b", "Shotgun"), ++i);
        itemSortOrders.Add(new("c7b01a0232ae53e478f0b4b92031c416", "Buckshot"), ++i);
        itemSortOrders.Add(new("84fdc501781979841a5e78d3a4bdfe03", "Slugs"), ++i);
        itemSortOrders.Add(new("6b328e39137971946aec0befbd285190", "AP Slugs"), ++i);

        itemSortOrders.Add(new("96048d612ab1ea246b50745a12b9b05e", "SMG"), ++i);
        itemSortOrders.Add(new("c7f58533040c3c646b6ea331e8dd0e76", "SMG Ammo"), ++i);
        itemSortOrders.Add(new("52c87180c4ed42c40903a92b40b127f5", "SMG Ammo T2"), ++i);

        itemSortOrders.Add(new("75416daac1a28094bb7b6d8f2d690c99", "Sniper"), ++i);
        itemSortOrders.Add(new("c7e359b8c04dfab4a92aceed52805dd5", "Enfield"), ++i);
        itemSortOrders.Add(new("ee1e9c8eb67fd2544982afda0ee6dcf2", "Sniper Ammo"), ++i);
        itemSortOrders.Add(new("b24d9fd34202ae94abd0448b6d05516d", "Sniper Ammo T2"), ++i);

        itemSortOrders.Add(new("da137d36a12c54e46b3a132180b98bb1", "Hand mortar"), ++i);
        itemSortOrders.Add(new("721881fe35216b3468df695b3d23acda", "Mortar grenade"), ++i);
        itemSortOrders.Add(new("57337a97eb81c7f4ab9f355ddc0d8fdc", "High-explosive mortar grenade"), ++i);

        itemSortOrders.Add(new("0670120db8e3ade4ba19a1928b19ce3d", "Gatling gun"), ++i);
        itemSortOrders.Add(new("0c215781eafd06a4ead9810f8800e13a", "Gatling ammo"), ++i);
        itemSortOrders.Add(new("58adab9d917be044b97b248738a6ce82", "Lewis gun"), ++i);
        itemSortOrders.Add(new("1a904cbf27967d44e8d8614e2867419a", "Lewis ammo"), ++i);

        // Melee
        itemSortOrders.Add(new("c36fdd64ef80d8648803c6ca6463fd63", "Pickaxe"), ++i);
        itemSortOrders.Add(new("06949b6bb6015ef4ea677324c635ddc1", "Cog Pickaxe"), ++i);
        itemSortOrders.Add(new("6511d384b377b4042bf25610c296e813", "Circular Saw"), ++i);

        // Tools

        itemSortOrders.Add(new("a8be95e4cba7ba844821734d0780d719", "Hacking tool"), ++i);
        itemSortOrders.Add(new("3fbc57594592bee4ca5f261484b635b5", "Revive Tool"), ++i);
        itemSortOrders.Add(new("bf164bd2a1500024cb1daf85b4118531", "Paint Tool"), ++i);

        itemSortOrders.Add(new("a2e86f35475b1294191575f698729f17", "Detonator"), ++i);
        itemSortOrders.Add(new("3b65509dc93e8bf4cbfb39454080f4f6", "Explosive"), ++i);

        itemSortOrders.Add(new("850bf93472186b54d8ebfd87223989db", "Grenade"), ++i);

        itemSortOrders.Add(new("7dc960ed2a495bc41a29d47359dcbf37", "Medkit"), ++i);

        itemSortOrders.Add(new("f1a5a5d0b8fcdbb4b9b24b9630258a67", "Dispenser"), ++i);
        itemSortOrders.Add(new("0a3be365ab582fc498495fb3b1e5e460", "HealingDevice"), ++i);
        itemSortOrders.Add(new("1fc2fb4280dbefd47a9e8c328feaca7c", "ArmorRepairDevice"), ++i);

        // Armor
        itemSortOrders.Add(new("e7111feccf1d6e649963eac87fddf20d", "Copper Armor Kit"), ++i);
        itemSortOrders.Add(new("13eb8795a0adb4e499377fcf8102894c", "Iron Armor Kit"), ++i);
        itemSortOrders.Add(new("02bd8b0bf0c7cf840a61f910289c882c", "Titanium Armor Kit"), ++i);

        // Repair
        itemSortOrders.Add(new("1bf6d40a49d9e2148a2d2389a768f15f", "Module repair kit"), ++i);
        itemSortOrders.Add(new("2f88af3168900fd47aca22d25bdf3db6", "Breach replacement"), ++i);

        // Destroyed Modules
        itemSortOrders.Add(new("58d09ebd1461f0d499578d175c40b664", "Destroyed production module T1"), ++i);
        itemSortOrders.Add(new("ff1f3d34d8c71574b944598d351c8815", "Destroyed production module T2"), ++i);
        itemSortOrders.Add(new("30e40c645683d9e47a14c2ef013ae3d6", "Destroyed production module T3"), ++i);
        itemSortOrders.Add(new("6e429490a8b23c1479001cf5a8261f84", "Destroyed refinery module T1"), ++i);
        itemSortOrders.Add(new("2b8e38028da543c43829be235e625ca1", "Destroyed refinery module T2"), ++i);
        itemSortOrders.Add(new("dae2caa1449bffb44971307eadccb2f1", "Destroyed refinery module T3"), ++i);
        itemSortOrders.Add(new("ac7f7c6ededd3d748bc2fb595b68f561", "Destroyed research module T1"), ++i);
        itemSortOrders.Add(new("e5be8b01d82e370439f481d4a4e148d7", "Destroyed research module T2"), ++i);
        itemSortOrders.Add(new("0c496107eadb88343b5fe35ebbf3a4c5", "Destroyed research module T3"), ++i);

        // Heads
        itemSortOrders.Add(new("a8a2e7eb3c5146f4ebf8970607b37c52", "Builder head"), ++i);
        itemSortOrders.Add(new("0af47bdf33b44ed40a527cdde8da0514", "Technician head"), ++i);
        itemSortOrders.Add(new("cafc4d008b3688c4e957f9404c45ebaa", "Engineer head"), ++i);
        itemSortOrders.Add(new("3ad5b5d8f1c0c0f4d82e85fc56707653", "Miner head"), ++i);
        itemSortOrders.Add(new("f1a2dd04063a9944fa5b0236bb11bbdd", "Foundryman head"), ++i);
        itemSortOrders.Add(new("8604f46bc1ad6104d830abe85a07a0dd", "Metallurgist head"), ++i);
        itemSortOrders.Add(new("087f8c24f97b6ea43a1921d9cb6ae239", "Explorer head"), ++i);
        itemSortOrders.Add(new("72a2dbe3afc8f384d9eb7472bd667d2f", "Chemist head"), ++i);
        itemSortOrders.Add(new("64d149d6ac860ae45b519da20f325743", "Scientist head"), ++i);

        // Intel
        itemSortOrders.Add(new("2910c00231f76c646a01684dd078f24a", "Intel production T1"), ++i);
        itemSortOrders.Add(new("8550516dc00b41e448a35d9246b71960", "Intel production T2"), ++i);
        itemSortOrders.Add(new("de49e8a2a5685b34e9cbd556749296f8", "Intel production T3"), ++i);
        itemSortOrders.Add(new("c5703a9caa05f054885f1c55e690cac8", "Intel refinery T1"), ++i);
        itemSortOrders.Add(new("d65ca4042608a104d87d9cfdde660ffc", "Intel refinery T2"), ++i);
        itemSortOrders.Add(new("8194be0ee20cc9b47b4bc7b97345a9a3", "Intel refinery T3"), ++i);
        itemSortOrders.Add(new("c835155f54e5a474c96746e6bfe0ecfa", "Intel research T1"), ++i);
        itemSortOrders.Add(new("8954ad7e13dff954caf1264906cbf48e", "Intel research T2"), ++i);
        itemSortOrders.Add(new("397238c7f2ba2c2498a97c731ebf3c75", "Intel research T3"), ++i);

        // Cores
        itemSortOrders.Add(new("831fffcfc9687254abc725a140675467", "Drillship core 1"), ++i);
        itemSortOrders.Add(new("3d8201489a2dd1146b53543aadcfe418", "Drillship core 2"), ++i);
        itemSortOrders.Add(new("0bf8f15db1616fc49a8965909fc56e33", "Drillship core 3"), ++i);

        itemSortOrders.Add(new("754bb9cef5e43e342b7cc746e63cc3e3", "Drillship core 1 (override)"), ++i);
        itemSortOrders.Add(new("9474dd6f982e06d43a9f7c6ac6c737e3", "Drillship core 2 (override)"), ++i);
        itemSortOrders.Add(new("74d276acce657d849a3545ac52375ebc", "Drillship core 3 (override)"), ++i);

        // Engines
        itemSortOrders.Add(new("ee7643bb8c3975640abff628bde9a9b7", "Engine 2"), ++i);
        itemSortOrders.Add(new("c01f451074ac3d04795d74be4e06fe91", "Engine 3"), ++i);

        // Segment
        itemSortOrders.Add(new("fd952475c91a3904fb3c5688b087be8a", "Drillship segment"), ++i);

        // Drill
        itemSortOrders.Add(new("cf1c0539d62990044a9b67688e898abf", "Hardened drill parts"), ++i);
        itemSortOrders.Add(new("a11806d071ae24c40b3de46aa4ed3bc3", "Hardened drill"), ++i);
        itemSortOrders.Add(new("0032bca7659e9e9459a465c50d3b6fbb", "Corundum drill parts"), ++i);
        itemSortOrders.Add(new("a41d6125f2945fd4cbadafa46df09bf0", "Corundum drill"), ++i);
        itemSortOrders.Add(new("d0b18a9fc5574b74c9b6df4e93d8eb20", "Diamond drill parts"), ++i);
        itemSortOrders.Add(new("130ff88e8664e3442ad12caea6fd7400", "Diamond drill"), ++i);

        // Tread
        itemSortOrders.Add(new("ff9a9b57602c4e6458f9c01dd8ecfa65", "Modified tracks parts"), ++i);
        itemSortOrders.Add(new("e1b4ffe7c3b0fe44db9d60f68b2a6340", "Modified tracks"), ++i);
        itemSortOrders.Add(new("be9ebd35950d57745ba1f3fdc76fd25c", "Improved tracks parts"), ++i);
        itemSortOrders.Add(new("3d937f4e86280e1428510afd3dd70104", "Improved tracks"), ++i);
        itemSortOrders.Add(new("ee866e83908cae24994ce5c17656a6d8", "Advanced tracks parts"), ++i);
        itemSortOrders.Add(new("c83d9a64b6f93f24b90578a3161f8df6", "Advanced tracks"), ++i);

        // Hull
        itemSortOrders.Add(new("54c206b89b5398f41a671b6f3a11a4a4", "Reinforced hull parts"), ++i);
        itemSortOrders.Add(new("d62e229c21b37dd429559bd9b8728d84", "Reinforced hull"), ++i);
        itemSortOrders.Add(new("efb34100e06bea247b15a978a5237cc2", "Steel hull parts"), ++i);
        itemSortOrders.Add(new("cac9c2f73bda1c04aac37c4a1cf89ce3", "Steel hull"), ++i);
        itemSortOrders.Add(new("f8cbf5d16b1a4a74e9cc30a152482648", "Titanium hull parts"), ++i);
        itemSortOrders.Add(new("904434a1cb2d03846a9c26d568a54920", "Titanium hull"), ++i);

        // Prod Schem
        itemSortOrders.Add(new("e9e152422201c3e4989ff113e13bfa84", "Production Tier 1 Schematics"), ++i);
        itemSortOrders.Add(new("1b3d424506d823f4d859a78655997cfb", "Upgrade basic production"), ++i);
        itemSortOrders.Add(new("c961d56fd4ca7c644abcb029eec8b993", "Upgrade advanced production"), ++i);

        // Ref Schem
        itemSortOrders.Add(new("cf7a13488f08f934185bd003b89c23f0", "Refining Tier 1 Schematics"), ++i);
        itemSortOrders.Add(new("e6a3240191e18654fb22c183c8cfdffd", "Upgrade basic refinery"), ++i);
        itemSortOrders.Add(new("2bd7b88db440ddf40b2032fc3843579b", "Upgrade advanced refinery"), ++i);

        // Sci Schem
        itemSortOrders.Add(new("faad87a6f6f69f642afc7af9bd2196a0", "Research Tier 1 Schematics"), ++i);
        itemSortOrders.Add(new("d095455c4b4555749bc3387b0204d35e", "Upgrade basic research"), ++i);
        itemSortOrders.Add(new("159e6147774427e48944028e31867280", "Upgrade advanced research"), ++i);

        // Exp Schem
        itemSortOrders.Add(new("5f8cd9632a5663443927c5cf09c210d9", "Simple Explosives"), ++i);
        itemSortOrders.Add(new("22af3ac761869484fa0b7acf735b5318", "Improved Explosives"), ++i);
        itemSortOrders.Add(new("49e4b97fd5b3e7c40b8702fb1a662ed9", "Advanced Explosives"), ++i);
        itemSortOrders.Add(new("2bfc828dc9788d645a221a53dbd4e1b8", "Starter Structures Schematic"), ++i);
        itemSortOrders.Add(new("cd9ae09a9822fe146ad880607f3f0e69", "Improved Structures Schematic"), ++i);

        // Coal
        itemSortOrders.Add(new("e89c0cdbf40a07f4ebb20d2865717a52", "Coal"), ++i);

        // Ores
        itemSortOrders.Add(new("d1c5ccba9f65302408be2e46975020e7", "Copper ore"), ++i);
        itemSortOrders.Add(new("1389347b3fca5534ba680b05ce1cf476", "Copper scrap metal"), ++i);
        itemSortOrders.Add(new("9386d447191c7aa4fa913943abd75481", "Copper ingot"), ++i);
        itemSortOrders.Add(new("8184e2f7fbec373469f650ff3febcf99", "Iron ore"), ++i);
        itemSortOrders.Add(new("1160b9c0f5386044a819adaa48d26f95", "Iron scrap metal"), ++i);
        itemSortOrders.Add(new("f74e4356dcd38b7418a666b63c0304b1", "Iron ingot"), ++i);
        itemSortOrders.Add(new("3d4fce1d9e298384ea12a6e66fa92ba2", "Titanium Ore"), ++i);
        itemSortOrders.Add(new("5abe2a64bf3553f4da476f43f31eb7e5", "Titanium Scrap Metal"), ++i);
        itemSortOrders.Add(new("c3d1b45a69512824fbade5378c5a4a52", "Titanium ingot"), ++i);

        // Alloys
        itemSortOrders.Add(new("8cbb0001e180fe241b3da6ef1018b3df", "Alloy T1 ingot"), ++i);
        itemSortOrders.Add(new("7d475c9d18e267f41b82f736ed19a194", "Alloy T2 ingot"), ++i);
        itemSortOrders.Add(new("13fbc577a43e7f34e914b3d8d8832c16", "Alloy T3 ingot"), ++i);

        // Secondary Ores
        itemSortOrders.Add(new("9ffb5e60912dc6a4280c317dbdbcab52", "SulfurOre"), ++i);
        itemSortOrders.Add(new("156562c6e6475dd4eb885291a4662a6f", "Sulfur powder"), ++i);
        itemSortOrders.Add(new("1846377ac119fd64ab8fd73dccfe0923", "Raw Crystals"), ++i);
        itemSortOrders.Add(new("63e5ebe76f201c549b93e73a3be1044a", "Crystal"), ++i);
        itemSortOrders.Add(new("98244c77b188a0740a2ba3df0dfab2fe", "Raw Diamond"), ++i);
        itemSortOrders.Add(new("7ba2d6c7d6bf2eb41b9732aa1b8f2396", "Diamond"), ++i);

        // Intermediaries (Copper)
        itemSortOrders.Add(new("ca8ecba733454c8439fdc1c068756eb2", "Copper bolts"), ++i);
        itemSortOrders.Add(new("8df9c647d90ecaa4e9539cdeb5e3683c", "Copper plates"), ++i);
        itemSortOrders.Add(new("ddf109b40b214a640967e3085841d22d", "Copper tubes"), ++i);
        itemSortOrders.Add(new("bafa87209ecbd97428e814d7580860dc", "Copper radiator"), ++i);
        itemSortOrders.Add(new("46d1d98e93bd44a48a55c9cf5337ee5d", "Copper wire"), ++i);
        itemSortOrders.Add(new("3b42ca843c8036b4087c1584eee1e406", "Copper Levers"), ++i);
        itemSortOrders.Add(new("0ee40de42e641e34689855fcd200f82a", "Copper gun components"), ++i);
        itemSortOrders.Add(new("0a1bdffa1c60d3c429dbf90cc5e9dc41", "Copper bullet casings"), ++i);

        // Intermediaries (Iron)
        itemSortOrders.Add(new("1e67627353287044d80186dc824db14b", "Iron bolts"), ++i);
        itemSortOrders.Add(new("a4a481934c0d6d743b38e9ea78069267", "Iron plates"), ++i);
        itemSortOrders.Add(new("272d8bc0a4ea1ba4c825db30b840a677", "Iron tubes"), ++i);
        itemSortOrders.Add(new("327cd2fff4fe89047829617583b96fff", "Iron frame"), ++i);
        itemSortOrders.Add(new("ce4da15226d4b4649a2047d48e66d135", "Iron gear"), ++i);
        itemSortOrders.Add(new("36564125a959788458eddb0bfda38f2d", "Iron bullet casings"), ++i);

        // Intermediaries (Titanium)
        itemSortOrders.Add(new("53a8f946b466b9e4d90b2544569ba062", "Titan bolts"), ++i);
        itemSortOrders.Add(new("f878209ee44486c4faaf53d535e39ffc", "Titan plates"), ++i);
        itemSortOrders.Add(new("b3a0b7be95f2ec146a98f25dd98e7f98", "Titan tubes"), ++i);
        itemSortOrders.Add(new("b9523c64a5674d148848640c143a4f02", "Titanium bullet casings"), ++i);

        // Intermediaries (Misc)
        itemSortOrders.Add(new("d328101fb2c64b44fbb0e2748a64a037", "Black powder"), ++i);
        itemSortOrders.Add(new("f4f1eb1effb618444ab53653636ef479", "Dials"), ++i);

        // Turret Ammo
        itemSortOrders.Add(new("f46cdfb659dd5f3428f5a1c9c1fe7d32", "Pistol Turret Ammo"), ++i);
        itemSortOrders.Add(new("cdd3ca2c103709d4395f67d08bef56f9", "Shotgun Turret Ammo"), ++i);
        itemSortOrders.Add(new("3bd794833a3c801498d50cb745f51734", "SMG Turret Ammo"), ++i);
        itemSortOrders.Add(new("66a6ec9baa4d140438c316b93c639a72", "Sniper Turret Ammo"), ++i);
        itemSortOrders.Add(new("6af41273ef98e88499f8a7d4e71430c6", "Mortar Turret Grenade"), ++i);
        itemSortOrders.Add(new("68125db51cd1b714d8cd8f1dd1e1d374", "Gatling Turret Ammo"), ++i);

        // Prod Devices
        itemSortOrders.Add(new("8b608e7646eaa814caaed60576d6ea71", "Pump"), ++i);
        itemSortOrders.Add(new("999489237d3e69443b139ccae6be3f2c", "Hydraulics"), ++i);
        itemSortOrders.Add(new("fcf67ebb367355c4795c56c0953b2017", "Transmission"), ++i);

        // Ref Devices
        itemSortOrders.Add(new("8ca4bb19538d15349a160e6df2036e1d", "Shredder"), ++i);
        itemSortOrders.Add(new("71da14bcfb171a44d9aabdeb79674527", "Boiler"), ++i);
        itemSortOrders.Add(new("a6a525934b8ccfc4997674ad830afc9d", "Furnace"), ++i);

        // Sci Devices
        itemSortOrders.Add(new("13614afd1e1e9ce48b1e152e84c5ae6c", "Converter"), ++i);
        itemSortOrders.Add(new("38b13a4a479a3f043a8b83e81c08d340", "Sensors"), ++i);
        itemSortOrders.Add(new("acadc09e5549c2942b7d57d11dc21f04", "Analyzer"), ++i);

        // Modules
        itemSortOrders.Add(new("7155d1834822b064a812b57eedb4fcac", "Coal Powerplant Tier 1"), ++i);
        itemSortOrders.Add(new("da53182cfeaac444db3c587904eb292f", "Coal Powerplant Tier 2"), ++i);
        itemSortOrders.Add(new("25c8f53e03229144f930b125870ef18e", "Coal Powerplant Tier 3"), ++i);
        itemSortOrders.Add(new("a94225c3369a28446a5d185bdbb38d57", "Geothermal Powerplant Tier 1"), ++i);
        itemSortOrders.Add(new("cd99b1154aa3d4b48a922c81877d528a", "Geothermal Powerplant Tier 3"), ++i);
        itemSortOrders.Add(new("e88f236cccc6b78488bcd03fcaa61d16", "Production Tier 1"), ++i);
        itemSortOrders.Add(new("ba98d563515d93a4f87264883c9e7507", "Production Tier 2"), ++i);
        itemSortOrders.Add(new("52d108d86d10cc044bc9503239eba930", "Production Tier 3"), ++i);
        itemSortOrders.Add(new("72b0b47f1ae773843a62186e24453fb6", "Refinery Tier 1"), ++i);
        itemSortOrders.Add(new("2d64396a31c055d43aff151e30ee4cb6", "Refinery Tier 2"), ++i);
        itemSortOrders.Add(new("527f1530e12c2f743a6145b62fad4921", "Refinery Tier 3"), ++i);
        itemSortOrders.Add(new("de637c6e60882324e8c4f49a7f322351", "Research Tier 1"), ++i);
        itemSortOrders.Add(new("5adf9866c6c484a47a9a2be39f97fa98", "Research Tier 2"), ++i);
        itemSortOrders.Add(new("a8841010102dd33438dd76dfa5e5b698", "Research Tier 3"), ++i);
        itemSortOrders.Add(new("38d294f9c4a553d4d947958321966f91", "Storage Tier 1"), ++i);
        itemSortOrders.Add(new("b0517105257182f49afcbe23088845de", "Storage Tier 2"), ++i);
        itemSortOrders.Add(new("86d7151630e909944991dbedc1998497", "Storage Tier 3"), ++i);

        itemSortOrders.Add(new("8512e60bb61e48149baf3db9f4d937a9", "Generic Tier 1"), ++i);
        itemSortOrders.Add(new("c5aee17ca93417444a9e222dad5c045c", "Generic Tier 2"), ++i);
        itemSortOrders.Add(new("bb232f8c6d7df2140bfa7225d2bf51f1", "Generic Tier 3"), ++i);

        // Modules (Turrets)
        itemSortOrders.Add(new("3bf96763d5dfb564aad936a087cb614e", "Pistol Turret Module"), ++i);
        itemSortOrders.Add(new("6dcf6c5ca3b8f1741af35a4011cdaa1e", "Shotgun Turret Module"), ++i);
        itemSortOrders.Add(new("4912009609358ea46bc2ceac554045e6", "SMG Turret Module"), ++i);
        itemSortOrders.Add(new("b40d3f9773a3a014c9ce1801b2696538", "Sniper Turret Module"), ++i);
        itemSortOrders.Add(new("a2a0d7a9fab7dee4f8b2f7a6d0912b5a", "Mortar Turret Module"), ++i);
        itemSortOrders.Add(new("4b17c7bc9d6c2ee46b7807292f26b432", "Gatling Turret Module"), ++i);

        itemSortOrders.Add(new("TurretController", "Turret Controller"), ++i);

        // Modules (Drones)
        itemSortOrders.Add(new("c7996bbb578dde34c9d80987dcf390a3", "Mining Drone Module"), ++i);
        itemSortOrders.Add(new("79c0b8b872145854cb53ed59b459020f", "Support Drone Module"), ++i);
        itemSortOrders.Add(new("931e863f377d25f42beb8137bc1b4252", "Turret Drone Module"), ++i);

        // Doors
        itemSortOrders.Add(new("6edc5f9c55fb25c48a63ad047bd38b32", "Door module"), ++i);
        itemSortOrders.Add(new("bffddb68717b5fb4fbfd2200ff6158db", "Window module"), ++i);

        // Station, hubs, and all interior devices follow.
        itemSortOrders.Add(new("ca0964a43824b38468eed492d2385ec4", "Hub production"), ++i);
        itemSortOrders.Add(new("d4446b96f5a46494e8bed91cc40c06b7", "Hub refinery"), ++i);
        itemSortOrders.Add(new("00175574f3d8b8c41b2da96cd19cfc40", "Hub research"), ++i);
        itemSortOrders.Add(new("b4fbc6dbf6156184383895f886d838bd", "Hub scrap"), ++i);

        itemSortOrders.Add(new("a985f4262370f4049a3943415f8fe308", "Production station (wide)"), ++i);
        itemSortOrders.Add(new("2db0a28025acc3f439e680c86bcaa9fb", "Refinery station (wide)"), ++i);
        itemSortOrders.Add(new("5bfc62bce5a139347ae57a7c2515bae1", "Research station (wide)"), ++i);
        itemSortOrders.Add(new("b3a64a40be848f842b29510b14e80182", "Scrap station (wide)"), ++i);

        itemSortOrders.Add(new("7c32d187420152f4da3a79d465cbe87a", "Production station"), ++i);
        itemSortOrders.Add(new("3b35b8f4f39847945b9881e25bb01f5a", "Refinery station"), ++i);
        itemSortOrders.Add(new("a7764724dfb030a47a531f7c5e87ff9e", "Research station"), ++i);
        itemSortOrders.Add(new("a28879ce9c7caab40a38781abb6af9ae", "Scrap station"), ++i);

        itemSortOrders.Add(new("f61e601e773ff884497d265728ceacaa", "Worktable"), ++i);
        itemSortOrders.Add(new("655ac6f1bdb43da4f9ee18c6285b41ff", "Refinery Worktable"), ++i);
        itemSortOrders.Add(new("493fb6e4e66a02a4a8c512e0b94b5414", "Research Worktable"), ++i);

        itemSortOrders.Add(new("d273efccf8a1b3b46b35e781da1d7b1e", "Chest"), ++i);

        itemSortOrders.Add(new("fd74b5cfbeca4f54caba56609b4585cd", "Controller system small"), ++i);
        itemSortOrders.Add(new("d1ef00215f1d81e43bccaafd94e3f874", "Controller manufacture small"), ++i);
        itemSortOrders.Add(new("a9d89fb653b26fc488ad963f756b467b", "Controller System Medium"), ++i);
        itemSortOrders.Add(new("773ceb48d01a9cb41913231634ac4ab8", "Controller Manufacture Medium"), ++i);
        itemSortOrders.Add(new("9941cf077a45c034ab0468d1ee7c1442", "Controller custom"), ++i);
        itemSortOrders.Add(new("ddb88eb052f394446822efd3668fe541", "Controller shutdown"), ++i);

        itemSortOrders.Add(new("2f37c2f7701fb8b44abefdcd03681b8b", "Copper door"), ++i);
        itemSortOrders.Add(new("54dff72cdbd77b146a34ad3e99a740ed", "Copper window"), ++i);
        itemSortOrders.Add(new("412f37021714e0f41acb8cba44b9e296", "Copper floor hole"), ++i);
        itemSortOrders.Add(new("5a7116a700e47a548b217b22de257084", "Copper floor"), ++i);
        itemSortOrders.Add(new("36a6599672ae13f49b0ec42133578d40", "Copper ladder"), ++i);
        itemSortOrders.Add(new("dc63525a705ab88438157d406108d8e9", "Copper wall hole"), ++i);
        itemSortOrders.Add(new("f40af8db8e467ac4ab2fd210ac9f2a6e", "Copper wall"), ++i);

        itemSortOrders.Add(new("f05b55976bda24c4eae5878abab676d9", "Display small"), ++i);
        itemSortOrders.Add(new("8df86ab1bb09cb34d831cd7eaec5e6dd", "Display medium"), ++i);
        itemSortOrders.Add(new("f54ad55a1555eee4c9e634afc077c4bb", "Display large"), ++i);

        itemSortOrders.Add(new("160a4eb9bedfae841a3df84aaff9ec29", "Panel core small"), ++i);
        itemSortOrders.Add(new("550c35b99061b8b4aaf7bccae8f50cf2", "Panel system small"), ++i);
        itemSortOrders.Add(new("cb7f84ebdc80e834dbbedb38851af64a", "Panel manufacture small"), ++i);
        itemSortOrders.Add(new("2e1f935fcfac51d4a9246f8a0b54438e", "Panel large"), ++i);
        itemSortOrders.Add(new("48d0935f09556884fa316d94ca00be36", "Panel system medium"), ++i);
        itemSortOrders.Add(new("11e7bacd68e5c0e4e90336d993031484", "Panel manufacture medium"), ++i);

        itemSortOrders.Add(new("7cc4fb82796808145bc0f1fa06cc7607", "Stats panel"), ++i);
        itemSortOrders.Add(new("4dc894129cceae8459840de3a228985f", "Storage door"), ++i);
        itemSortOrders.Add(new("f87de61209b99e440a505d1e00fa1099", "Periscope"), ++i);
        itemSortOrders.Add(new("4c0e51c601608544fbd2e5a2b50f5bcc", "Pilot seat"), ++i);
        itemSortOrders.Add(new("7f0eb007c3d86054dabe16a19fa0583d", "Turret controller"), ++i);
        itemSortOrders.Add(new("6398b069860ade44082f9d7b68e5ffb2", "Lever stand"), ++i);
        itemSortOrders.Add(new("2b016a075df938c4a8e20efbdcda209c", "Light"), ++i);
        itemSortOrders.Add(new("2259c7da81d447c4e9920cef56b51a81", "Long distance radio"), ++i);
        itemSortOrders.Add(new("f077e3ec6988bc24dbd443d0b719d792", "MapStand"), ++i);
        itemSortOrders.Add(new("147bae0548753c047a4848555601fe5f", "BannerLarge"), ++i);
        itemSortOrders.Add(new("aa91b28ceaa9e5646b5b4fa451835124", "BannerSmall"), ++i);
        itemSortOrders.Add(new("81f42329261e3d948851ae235793ad10", "Bed"), ++i);
        itemSortOrders.Add(new("c4097c5141470db448657c5930b8b359", "Spawn Tube"), ++i);

        return itemSortOrders;
    }
}