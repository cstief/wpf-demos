#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockingAdapterMVVM
{
    public enum DockState
    {
        Dock,
        Document,
        Float,
        AutoHidden,
        Hidden
    }

    public enum DockSide
    {
        Bottom,
        Left,
        None,
        Right,
        Tabbed,
        Top
    }

    public enum DockAbility
    {
        All,
        Bottom,
        Horizontal,
        Left,
        None,
        Right,
        Tabbed,
        Top,
        Vertical
    }
}
