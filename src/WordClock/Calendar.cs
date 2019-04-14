﻿// <copyright file="Calendar.cs" company="zondy">
//		Copyright (c) Zondy. All rights reserved.
// </copyright>
// <author>WeiWenGang</author>
// <date>2019/4/11 0:00:58</date>
// <summary>文件功能描述</summary>
// <modify>
//		修改人:		
//		修改时间:	
//		修改描述:	
//		版本: 1.0	
// </modify>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordClock
{
    public class ClockCalendar
    {
        float _w;
        float _h;
        string _fontName;

        public class TextInfo
        {
            public float X { get; set; }
            public float Y { get; set; }
            public string Text { get; set; }
            public float Angle { get; set; }

        }

        public Action<TextInfo> Drawer;

        public ClockCalendar(float w, float h, string fontName)
        {
            _w = w;
            _h = h;
            _fontName = fontName;
        }


    }
}
