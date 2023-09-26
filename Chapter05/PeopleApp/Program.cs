﻿using Packt.Shared;

Person max = new();
max.Name = "Max Burrows";
max.DateOfBirth = new DateTime(1997, 11, 5);
max.FavouriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
max.BucketList = 
    WondersOfTheAncientWorld.HangingGardensOfBabylon
    | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: max.Name,
    arg1: max.DateOfBirth);
WriteLine(format: "{0}'s favourite wonder is {1}. Its integer is {2}.",
    arg0: max.Name,
    arg1: max.FavouriteAncientWonder,
    arg2: (int) max.FavouriteAncientWonder);
WriteLine($"{max.Name}'s bucket list is {max.BucketList}");

Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7)
};
WriteLine(format: "{0} was born on {1:dd MMM yy}",
    arg0: alice.Name,
    arg1: alice.DateOfBirth);
