﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindEditor
{
    public enum FourCC
    {
        ACTR,
        ACT0,
        ACT1,
        ACT2,
        ACT3,
        ACT4,
        ACT5,
        ACT6,
        ACT7,
        ACT8,
        ACT9,
        ACTa,
        ACTb,

        SCOB,
        SCO0,
        SCO1,
        SCO2,
        SCO3,
        SCO4,
        SCO5,
        SCO6,
        SCO7,
        SCO8,
        SCO9,
        SCOa,
        SCOb,

        TRES,
        TRE0,
        TRE1,
        TRE2,
        TRE3,
        TRE4,
        TRE5,
        TRE6,
        TRE7,
        TRE8,
        TRE9,
        TREa,
        TREb,

        MA2D,
        ma2D,
        AROB,
        RARO,
        CAMR,
        RCAM,
        EnvR,
        Colo,
        Pale,
        Virt,
        DMAP,
        FLOR,
        DOOR,
        TGDR,
        EVNT,
        FILI,
        LGHT,
        LBNK,
        MECO,
        MEMA,
        MULT,
        PATH,
        RPAT,
        PPNT,
        RPPN,
        RTBL,
        SCLS,
        PLYR,
        SHIP,
        SOND,
        STAG,
        LGTV,
        TGSC,
        TGOB,

        NONE  // Default
    }

    public static class FourCCConversion
    {
        public static FourCC GetEnumFromString(string fourcc)
        {
            FourCC result = FourCC.NONE;

            if (fourcc == "2DMA")
                return FourCC.MA2D;
            else if (fourcc == "2Dma")
                return FourCC.ma2D;

            bool success = Enum.TryParse<FourCC>(fourcc, out result);

            if (success)
                return result;
            else
                throw new FormatException($"String to FourCC conversion failed for string { fourcc }!");
        }

        public static string GetStringFromEnum(FourCC fourcc)
        {
            if (fourcc == FourCC.MA2D)
                return "2DMA";
            else if (fourcc == FourCC.ma2D)
                return "2Dma";

            return fourcc.ToString();
        }

        public static string GetDescriptionFromEnum(FourCC fourcc)
        {
            switch (fourcc)
            {
                case FourCC.MA2D:
                    return "Minimap";
                case FourCC.ACTR:
                    return "Default Layer";
                case FourCC.ACT0:
                    return "Layer 0";
                case FourCC.ACT1:
                    return "Layer 1";
                case FourCC.ACT2:
                    return "Layer 2";
                case FourCC.ACT3:
                    return "Layer 3";
                case FourCC.ACT4:
                    return "Layer 4";
                case FourCC.ACT5:
                    return "Layer 5";
                case FourCC.ACT6:
                    return "Layer 6";
                case FourCC.ACT7:
                    return "Layer 7";
                case FourCC.ACT8:
                    return "Layer 8";
                case FourCC.ACT9:
                    return "Layer 9";
                case FourCC.ACTa:
                    return "Layer 10";
                case FourCC.ACTb:
                    return "Layer 11";
                case FourCC.AROB:
                    return "Camera POIs";
                case FourCC.RARO:
                    return "Camera POIs (Events)";
                case FourCC.CAMR:
                    return "Camera Behavior (CAMR)";
                case FourCC.RCAM:
                    return "Camera Behavior (RCAM)";
                case FourCC.EnvR:
                    return "Environment Lighting";
                case FourCC.Colo:
                    return "EnvLighting ToD Colors";
                case FourCC.Pale:
                    return "EnvLighting Palette";
                case FourCC.Virt:
                    return "Skybox Colors";
                case FourCC.DMAP:
                    return "Dungeon Map";
                case FourCC.FLOR:
                    return "Dungeon Floors";
                case FourCC.DOOR:
                    return "Doors (DOOR)";
                case FourCC.TGDR:
                    return "Doors (TGDR)";
                case FourCC.EVNT:
                    return "Events";
                case FourCC.FILI:
                    return "Room Properties";
                case FourCC.LGHT:
                    return "Interior Lights";
                case FourCC.LBNK:
                    return "Layer Bank";
                case FourCC.MECO:
                    return "MECO";
                case FourCC.MEMA:
                    return "MEMA";
                case FourCC.MULT:
                    return "Room Translation";
                case FourCC.PATH:
                    return "Paths (PATH)";
                case FourCC.RPAT:
                    return "Paths (RPAT)";
                case FourCC.PPNT:
                    return "Path Waypoints (PPNT)";
                case FourCC.RPPN:
                    return "Path Waypoints (RPPN)";
                case FourCC.RTBL:
                    return "Adjacent Loaded Rooms";
                case FourCC.SCLS:
                    return "Exit List";
                case FourCC.SCOB:
                    return "Default Layer";
                case FourCC.SCO0:
                    return "Layer 0";
                case FourCC.SCO1:
                    return "Layer 1";
                case FourCC.SCO2:
                    return "Layer 2";
                case FourCC.SCO3:
                    return "Layer 3";
                case FourCC.SCO4:
                    return "Layer 4";
                case FourCC.SCO5:
                    return "Layer 5";
                case FourCC.SCO6:
                    return "Layer 6";
                case FourCC.SCO7:
                    return "Layer 7";
                case FourCC.SCO8:
                    return "Layer 8";
                case FourCC.SCO9:
                    return "Layer 9";
                case FourCC.SCOa:
                    return "Layer 10";
                case FourCC.SCOb:
                    return "Layer 11";
                case FourCC.PLYR:
                    return "Player Spawns";
                case FourCC.SHIP:
                    return "Ship Spawns";
                case FourCC.SOND:
                    return "Ambient Soundscape";
                case FourCC.STAG:
                    return "Stage Settings";
                case FourCC.TRES:
                    return "Default Layer";
                case FourCC.TRE0:
                    return "Layer 0";
                case FourCC.TRE1:
                    return "Layer 1";
                case FourCC.TRE2:
                    return "Layer 2";
                case FourCC.TRE3:
                    return "Layer 3";
                case FourCC.TRE4:
                    return "Layer 4";
                case FourCC.TRE5:
                    return "Layer 5";
                case FourCC.TRE6:
                    return "Layer 6";
                case FourCC.TRE7:
                    return "Layer 7";
                case FourCC.TRE8:
                    return "Layer 8";
                case FourCC.TRE9:
                    return "Layer 9";
                case FourCC.TREa:
                    return "Layer 10";
                case FourCC.TREb:
                    return "Layer 11";
                case FourCC.LGTV:
                    return "Shadow Cast Origin";
                case FourCC.TGSC:
                    return "TGSC";
                case FourCC.TGOB:
                    return "TGOB";
                default:
                    return $"Unsupported FourCC ({ fourcc })";
            }
        }

        public static Type GetTypeFromEnum(FourCC value)
        {
            switch (value)
            {
                case FourCC.SCLS:
                    return typeof(ExitData);
            }

            return null;
        }
    }
}
