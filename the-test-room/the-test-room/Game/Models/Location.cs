﻿namespace the_test_room.Game.Models;
public class Location
{
    public string Id {  get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public List<string> NPCs { get; set; }
    public List<string> DestinationIds { get; set; }
}
