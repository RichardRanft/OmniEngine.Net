﻿// WinterLeaf Entertainment
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
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<TerrainBrushSoftnessCurveDlg>))]
    public class TerrainBrushSoftnessCurveDlg : GuiControl
    {
        [ConsoleInteraction(true, "TerrainBrushSoftnessCurveDlg_initialize")]
        public static void initialize()
        {
            #region GuiControl (TerrainBrushSoftnessCurveDlg, EditorGuiGroup)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiControl", "TerrainBrushSoftnessCurveDlg, EditorGuiGroup", typeof (TerrainBrushSoftnessCurveDlg));
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiOverlayProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "0 0";
            oc_Newobject10["Extent"] = "800 600";
            oc_Newobject10["MinExtent"] = "8 8";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["hovertime"] = "1000";

            #region GuiWindowCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["Enabled"] = "1";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject9["HorizSizing"] = "center";
            oc_Newobject9["VertSizing"] = "center";
            oc_Newobject9["position"] = "231 204";
            oc_Newobject9["Extent"] = "175 228";
            oc_Newobject9["MinExtent"] = "8 8";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["Margin"] = "0 0 0 0";
            oc_Newobject9["Padding"] = "0 0 0 0";
            oc_Newobject9["AnchorTop"] = "1";
            oc_Newobject9["AnchorBottom"] = "0";
            oc_Newobject9["AnchorLeft"] = "1";
            oc_Newobject9["AnchorRight"] = "0";
            oc_Newobject9["resizeWidth"] = "0";
            oc_Newobject9["resizeHeight"] = "0";
            oc_Newobject9["canMove"] = "1";
            oc_Newobject9["canClose"] = "0";
            oc_Newobject9["canMinimize"] = "0";
            oc_Newobject9["canMaximize"] = "0";
            oc_Newobject9["minSize"] = "50 50";
            oc_Newobject9["EdgeSnap"] = "0";
            oc_Newobject9["text"] = "Brush Softness Curve";

            #region GuiButtonCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "84 196";
            oc_Newobject1["Extent"] = "83 24";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["Command"] = "TerrainBrushSoftnessCurveDlg.onOk();";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["text"] = "Ok";
            oc_Newobject1["groupNum"] = "-1";
            oc_Newobject1["buttonType"] = "PushButton";
            oc_Newobject1["useMouseEvents"] = "0";

            #endregion

            oc_Newobject9["#Newobject1"] = oc_Newobject1;

            #region GuiFilterCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiFilterCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["internalName"] = "FilterCurveCtrl";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "35 46";
            oc_Newobject2["Extent"] = "130 128";
            oc_Newobject2["MinExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["controlPoints"] = "7";
            oc_Newobject2["filter"] = "1 0.833333 0.666667 0.5 0.333333 0.166667 0";
            oc_Newobject2["identity"] = "1 0";

            #endregion

            oc_Newobject9["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "8 43";
            oc_Newobject3["Extent"] = "22 17";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["Margin"] = "0 0 0 0";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["text"] = "Hard";
            oc_Newobject3["maxLength"] = "1024";

            #endregion

            oc_Newobject9["#Newobject3"] = oc_Newobject3;

            #region GuiTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "11 159";
            oc_Newobject4["Extent"] = "20 19";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["text"] = "Soft";
            oc_Newobject4["maxLength"] = "1024";

            #endregion

            oc_Newobject9["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "36 174";
            oc_Newobject5["Extent"] = "33 19";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["text"] = "Inside";
            oc_Newobject5["maxLength"] = "1024";

            #endregion

            oc_Newobject9["#Newobject5"] = oc_Newobject5;

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "129 176";
            oc_Newobject6["Extent"] = "39 17";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["text"] = "Outside";
            oc_Newobject6["maxLength"] = "1024";

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region GuiButtonCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "7 196";
            oc_Newobject7["Extent"] = "69 24";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "Canvas.popDialog( TerrainBrushSoftnessCurveDlg );";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["text"] = "Cancel";
            oc_Newobject7["groupNum"] = "-1";
            oc_Newobject7["buttonType"] = "PushButton";
            oc_Newobject7["useMouseEvents"] = "0";

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region GuiButtonCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "122 26";
            oc_Newobject8["Extent"] = "44 17";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["Command"] = "TerrainBrushSoftnessCurveDlg.resetCurve();";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["text"] = "Reset";
            oc_Newobject8["groupNum"] = "-1";
            oc_Newobject8["buttonType"] = "PushButton";
            oc_Newobject8["useMouseEvents"] = "0";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject10.Create();
        }

        public override void onWake()
        {
            GuiFilterCtrl curve = findObjectByInternalName("FilterCurveCtrl", true);
            curve.setValue(((SimObject) "ETerrainEditor")["softSelectFilter"]);
        }

        [ConsoleInteraction]
        public void onOK()
        {
            GuiFilterCtrl curve = findObjectByInternalName("FilterCurveCtrl", true);
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            ETerrainEditor.softSelectFilter = curve.getValue();
            ETerrainEditor.resetSelWeights(true);

            ((GuiCanvas) "Canvas").popDialog(this);
        }

        [ConsoleInteraction]
        public void resetCurve()
        {
            GuiFilterCtrl curve = findObjectByInternalName("FilterCurveCtrl", true);
            curve.call("Identity");
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TerrainBrushSoftnessCurveDlg ts, string simobjectid)
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
        public static bool operator !=(TerrainBrushSoftnessCurveDlg ts, string simobjectid)
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
        public static implicit operator string(TerrainBrushSoftnessCurveDlg ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator TerrainBrushSoftnessCurveDlg(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (TerrainBrushSoftnessCurveDlg) Omni.self.getSimObject(simobjectid, typeof (TerrainBrushSoftnessCurveDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TerrainBrushSoftnessCurveDlg ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TerrainBrushSoftnessCurveDlg(int simobjectid)
        {
            return (TerrainBrushSoftnessCurveDlg) Omni.self.getSimObject((uint) simobjectid, typeof (TerrainBrushSoftnessCurveDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TerrainBrushSoftnessCurveDlg ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TerrainBrushSoftnessCurveDlg(uint simobjectid)
        {
            return (TerrainBrushSoftnessCurveDlg) Omni.self.getSimObject(simobjectid, typeof (TerrainBrushSoftnessCurveDlg));
        }

        #endregion
    }
}