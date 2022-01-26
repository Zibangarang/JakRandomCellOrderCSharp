﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Jak_1_Cell_Order_Randomizer_CSharp
{
    internal class Program
    {
        static readonly int _cellCount = 94;
        static readonly int _hubOne = 34;
        static bool[] duplicate = new bool[_cellCount];
        static List<string> _randomized = new List<string>();
        static List<string> _cells = new List<string>
        {
        "Geyser: Cell on path",
        "Geyser: Scout flies",
        "Geyser: Open blue eco door",
        "Geyser: Climb the cliff",
        "Sandover: Yakows",
        "Sandover: Mayor orbs",
        "Sandover: Uncle orbs",
        "Sandover: Oracle orbs",
        "Sandover: Oracle orbs",
        "Sandover: Scout flies",
        "Sentinel: Pelican",
        "Sentinel: Cannon",
        "Sentinel: Middle sentinel",
        "Sentinel: Green eco cloggers",
        "Sentinel: Seagulls",
        "Sentinel: Flut flut egg",
        "Sentinel: Explore the beach",
        "Sentinel: Scout flies",
        "FJ: Mirrors",
        "FJ: Fish",
        "FJ: Swim to island",
        "FJ: Locked blue eco door",
        "FJ: Open blue eco vent",
        "FJ: Top of tower",
        "FJ: Plant boss",
        "FJ: Scout flies",
        "Misty: Pillar platform",
        "Misty: Cannon",
        "Misty: Ambush",
        "Misty: On top of ship",
        "Misty: Zeppelins",
        "Misty: Wooden ramp",
        "Misty: Scout flies",
        "Misty: Muse",
        "FC: Scout flies",
        "FC: Reach end",
        "Rock Village: Gambler orbs",
        "Rock Village: Geologist orbs",
        "Rock Village: Warrior orbs",
        "Rock Village: Oracle orbs",
        "Rock Village: Oracle orbs",
        "Rock Village: Scout flies",
        "Basin: Moles",
        "Basin: Race",
        "Basin: Over the lake",
        "Basin: Plants",
        "Basin: Purple rings",
        "Basin: Blue rings",
        "Basin: Flying lurkers",
        "Basin: Scout flies",
        "LPC: Pipe cell",
        "LPC: Circle room",
        "LPC: Puzzle",
        "LPC: Piggyback tm",
        "LPC: Far side of pool",
        "LPC: Bottom of city",
        "LPC: Raise the chamber",
        "LPC: Scout flies",
        "Boggy: Tether cell 1",
        "Boggy: Tether cell 2",
        "Boggy: Tether cell 3",
        "Boggy: Tether cell 4",
        "Boggy: Rats",
        "Boggy: Ride Flut Flut",
        "Boggy: Ambush",
        "Boggy: Scout flies",
        "Mountain pass: Klaww",
        "Mountain pass: Secret cell",
        "Mountain pass: Reach end",
        "Mountain pass: Scout Flies",
        "VC: Miners",
        "VC: Miners",
        "VC: Miners",
        "VC: Miners",
        "VC: Oracle orbs",
        "VC: Oracle orbs",
        "VC: Secret cell",
        "VC: Scout flies",
        "Spider Cave: Gnawing lurkers",
        "Spider Cave: Dark eco crystals",
        "Spider Cave: Dark cave",
        "Spider Cave: Top of robot",
        "Spider Cave: Poles",
        "Spider Cave: Spider tunnel",
        "Spider Cave: Platforms",
        "Spider Cave: Scout flies",
        "Snowy: Yellow vent",
        "Snowy: Glacier troops",
        "Snowy: Blockers",
        "Snowy: Secret cell",
        "Snowy: Fortress door",
        "Snowy: Fortress",
        "Snowy: Lurker cave",
        "Snowy: Scout flies"
        };

        static void Main(string[] args)
        {
            RandomizeGeyser();
            RandomizeHub1();
            RandomizeTheRest();
            ExportXML();
        }

        static void RandomizeGeyser()
        {
            Random r = new Random();
            int cellNumber;

            for (int i = 0; i < 4; i++)
            { // This just randomizes geyser cell order, since you have to get all 4
                cellNumber = r.Next() % 4;
                if (duplicate[cellNumber]) i--;
                while (duplicate[cellNumber] == false)
                {
                    _randomized.Add($"{i+1}. {_cells[cellNumber]}");
                    duplicate[cellNumber] = true;
                }
            }
        }

        static void RandomizeHub1()
        {
            Random r = new Random();
            int cellNumber;
            int orbCells = 0;
            bool impossiblePurchase;

            for (int i = 0; i < 16; i++)
            { // Hub one cells, ain't nobody doing FCS for this.
                do
                {
                    do
                    {
                        if (duplicate[19])
                            cellNumber = r.Next() % _hubOne;
                        else cellNumber = r.Next() % (_hubOne - 8); // This prevents you from getting misty cells before doing fish.

                        if (duplicate[19] == false && orbCells == 3 && cellNumber == 7 || cellNumber == 8)
                        {
                            impossiblePurchase = true;
                        }
                        else
                        {
                            impossiblePurchase = false;
                        }

                    } while (duplicate[23] == false && cellNumber == 22 || cellNumber == 24); // This prevents you from getting cells inside temple before top of tower.
                } while (impossiblePurchase);
                if (duplicate[cellNumber]) i--;
                if (cellNumber > 4 && cellNumber < 9) orbCells++; // This keeps track of how many cells you've been given that require buying.

                while (duplicate[cellNumber] == false)
                {
                    _randomized.Add($"{i+5}. {_cells[cellNumber]}");
                    duplicate[cellNumber] = true;
                }
            }

        }

        static void RandomizeTheRest()
        {
            Random r = new Random();
            int cellNumber;
            int fcCheck = 0;

            for (int i = 0; i < 52; i++)
            {
                do
                {
                    do
                    {
                        do
                        {
                            if (duplicate[35] == false) // This makes sure you don't get hub 2/3 cells before "reach the end of fire canyon".
                                cellNumber = r.Next() % 36;
                            else if ((i - fcCheck) < 3) // This is just so that you don't get snowy cells before you've been able to unlock gondola, aka 2 cells after FC.
                                cellNumber = r.Next() % (_cellCount - 8);
                            else cellNumber = r.Next() % _cellCount;
                        } while (duplicate[19] == false && cellNumber >= (_hubOne - 8) && cellNumber < _hubOne); // Again, no misty cells before fish.
                    } while (duplicate[23] == false && cellNumber == 22 || cellNumber == 24); // Again, no temple before top of tower.
                } while (duplicate[46] == false && cellNumber == 47); // This makes sure you don't get blue rings before purple rings.
                if (cellNumber == 35)
                    fcCheck = i;
                if (duplicate[cellNumber])
                    i--;

                while (duplicate[cellNumber] == false)
                {
                    _randomized.Add($"{i+21}. {_cells[cellNumber]}");
                    duplicate[cellNumber] = true;
                }
            }
        }

        static void ExportXML()
        {
            Run run = new Run();
            run.GameIcon = new object();
            run.GameName = "Jak and Daxter: The Precursor Legacy";
            run.CategoryName = "Random Cell Order";
            run.version = "1.7.0";
            run.Metadata = new RunMetadata()
            {
                Run = new RunMetadataRun()
                {
                    id = ""
                },
                Platform = new RunMetadataPlatform()
                {
                    usesEmulator = "False"
                },
                Region = new object()
            };
            run.Offset = "-00:00:01.6000000";
            run.AttemptCount = 0;
            List<RunSegment> segments = new List<RunSegment>();

            foreach(string s in _randomized)
            {
                segments.Add(new RunSegment()
                {
                    Name = s,
                    Icon = new object(),
                    BestSegmentTime = new object(),
                    SegmentHistory = new object(),
                    SplitTimes = new RunSegmentSplitTimes()
                });
            }

            //After this, segments for Lava Tube and final boss
            segments.Add(new RunSegment()
            {
                Name = "Lava Tube",
                Icon = new object(),
                BestSegmentTime = new object(),
                SegmentHistory = new object(),
                SplitTimes = new RunSegmentSplitTimes()
            });
            segments.Add(new RunSegment()
            {
                Name = "Final boss",
                Icon = new object(),
                BestSegmentTime = new object(),
                SegmentHistory = new object(),
                SplitTimes = new RunSegmentSplitTimes()
            });

            run.Segments = segments.ToArray();
            run.AutoSplitterSettings = new object();

            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(Run));

            var path = Directory.GetCurrentDirectory() + "//RandomCellOrder.lss";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, run);
            file.Close();
        }
    }
}
