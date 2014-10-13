// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment�s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GuiColorPickerCtrl_Base>))]
    public partial class GuiColorPickerCtrl_Base : GuiControl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiColorPickerCtrl_Base ts, string simobjectid)
        {
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(GuiColorPickerCtrl_Base ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(GuiColorPickerCtrl_Base ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiColorPickerCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiColorPickerCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiColorPickerCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiColorPickerCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiColorPickerCtrl_Base(int simobjectid)
        {
            return (GuiColorPickerCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiColorPickerCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiColorPickerCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiColorPickerCtrl_Base(uint simobjectid)
        {
            return (GuiColorPickerCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiColorPickerCtrl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("ColorPicker")]
        public bool actionOnMove
        {
            get { return Omni.self.GetVar(_ID + ".actionOnMove").AsBool(); }
            set { Omni.self.SetVar(_ID + ".actionOnMove", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("ColorPicker")]
        public ColorF baseColor
        {
            get { return Omni.self.GetVar(_ID + ".baseColor").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".baseColor", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("ColorPicker")]
        public TypeGuiColorPickMode displayMode
        {
            get { return (TypeGuiColorPickMode) Omni.self.GetVar(_ID + ".displayMode"); }
            set { Omni.self.SetVar(_ID + ".displayMode", value.ToString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("ColorPicker")]
        public ColorF pickColor
        {
            get { return Omni.self.GetVar(_ID + ".pickColor").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".pickColor", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("ColorPicker")]
        public int selectorGap
        {
            get { return Omni.self.GetVar(_ID + ".selectorGap").AsInt(); }
            set { Omni.self.SetVar(_ID + ".selectorGap", value.AsString()); }
        }

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("ColorPicker")]
        public bool showReticle
        {
            get { return Omni.self.GetVar(_ID + ".showReticle").AsBool(); }
            set { Omni.self.SetVar(_ID + ".showReticle", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Gets the current position of the selector)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public Point2I getSelectorPos()
        {
            return new Point2I(m_ts.fn_GuiColorPickerCtrl_getSelectorPos(_ID));
        }

        /// <summary>
        /// Sets the current position of the selector)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setSelectorPos(Point2I newPos)
        {
            m_ts.fn_GuiColorPickerCtrl_setSelectorPos(_ID, newPos.AsString());
        }

        /// <summary>
        /// Forces update of pick color)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void updateColor()
        {
            m_ts.fn_GuiColorPickerCtrl_updateColor(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public GuiColorPickerCtrl_Base()
        {
        }
    }
}