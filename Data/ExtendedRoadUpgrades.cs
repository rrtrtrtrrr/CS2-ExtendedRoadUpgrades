﻿using ExtendedRoadUpgrades.Models;
using Game.Prefabs;
using System.Collections.Generic;

namespace ExtendedRoadUpgrades.Data
{
    /// <summary>
    /// Main container of all the available upgrade modes.
    /// This is not intended as an example of how to design a proper C# project so I'll
    /// just dump everything I need into a static variable and call it a day.
    /// 
    /// Please don't use my code to learn how to program! :)
    /// </summary>
    internal class ExtendedRoadUpgrades
    {
        public static IEnumerable<ExtendedRoadUpgradeModel> Modes = new[]
        {
            // Quay
            new ExtendedRoadUpgradeModel
            {
                Id = "Quay",
                Name = new Dictionary<string, string> {
                    {
                        "en-US",
                        "Quay"
                    }
                },
                Description = new Dictionary<string, string> {
                    {
                        "en-US",
                        "A quay, if you installed this mod you know what it is :)"
                    }
                },
                m_SetUpgradeFlags = new CompositionFlags
                {
                    m_Right = CompositionFlags.Side.Raised
                },
                m_UnsetUpgradeFlags = new CompositionFlags
                {
                    m_General = CompositionFlags.General.Elevated,
                    m_Right = CompositionFlags.Side.WideSidewalk | CompositionFlags.Side.PrimaryBeautification | CompositionFlags.Side.Lowered
                },

                // TODO: not sure how this works yet
                m_SetState = new[]
                {
                    NetPieceRequirements.Raised
                },
                m_UnsetState = new[]
                {
                    NetPieceRequirements.Lowered,
                    NetPieceRequirements.Elevated,
                    NetPieceRequirements.LowTransition,
                    NetPieceRequirements.OppositeLowTransition
                }
            },

            // Retaining Wall
            new ExtendedRoadUpgradeModel
            {
                Id = "RetainingWall",
                Name = new Dictionary<string, string> {
                    {
                        "en-US",
                        "Retaining Wall"
                    }
                },
                Description = new Dictionary<string, string> {
                    {
                        "en-US",
                        "A retaining wall, if you installed this mod you know what it is :)"
                    }
                },
                m_SetUpgradeFlags = new CompositionFlags
                {
                    m_Right = CompositionFlags.Side.Lowered
                },
                m_UnsetUpgradeFlags = new CompositionFlags
                {
                    m_General = CompositionFlags.General.Elevated,
                    m_Right = CompositionFlags.Side.WideSidewalk | CompositionFlags.Side.PrimaryBeautification | CompositionFlags.Side.Raised
                },

                // TODO: not sure how this works yet
                m_SetState = new[]
                {
                    NetPieceRequirements.Lowered
                },
                m_UnsetState = new[]
                {
                    NetPieceRequirements.Raised,
                    NetPieceRequirements.Elevated,
                    NetPieceRequirements.LowTransition,
                    NetPieceRequirements.OppositeLowTransition
                }
            },

            // Elevated
            new ExtendedRoadUpgradeModel
            {
                Id = "Elevated",
                Name = new Dictionary<string, string> {
                    {
                        "en-US",
                        "Elevated"
                    }
                },
                Description = new Dictionary<string, string> {
                    {
                        "en-US",
                        "Elevated mode, kind of similar to bridges"
                    }
                },
                m_SetUpgradeFlags = new CompositionFlags
                {
                    m_General = CompositionFlags.General.Elevated
                },
                m_UnsetUpgradeFlags = new CompositionFlags
                {
                    m_Right = CompositionFlags.Side.WideSidewalk | CompositionFlags.Side.PrimaryBeautification | CompositionFlags.Side.Raised | CompositionFlags.Side.Lowered,
                    m_Left = CompositionFlags.Side.WideSidewalk | CompositionFlags.Side.PrimaryBeautification | CompositionFlags.Side.Raised | CompositionFlags.Side.Lowered
                },

                // TODO: not sure how this works yet
                m_SetState = new[]
                {
                    NetPieceRequirements.Elevated
                },
                m_UnsetState = new[]
                {
                    NetPieceRequirements.Raised,
                    NetPieceRequirements.Lowered,
                    NetPieceRequirements.LowTransition,
                    NetPieceRequirements.OppositeLowTransition
                }
            }
        };
    }
}
