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

#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
{
    [TypeConverter(typeof (TypeConverterGeneric<LightRayPostEffect>))]
    public class LightRayPostEffect : PostEffect
    {

        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void preProcess()
        {
            this["targetScale"] = sGlobal["$LightRayPostFX::resolutionScale"] + " " + sGlobal["$LightRayPostFX::resolutionScale"];
        }

        public override void setShaderConsts()
        {
            setShaderConst("$brightScalar", sGlobal["$LightRayPostFX::brightScalar"]);
            PostEffect pfx = findObjectByInternalName("final", true);

            pfx.setShaderConst("$numSamples", sGlobal["$LightRayPostFX::numSamples"]);
            pfx.setShaderConst("$density", sGlobal["$LightRayPostFX::density"]);
            pfx.setShaderConst("$weight", sGlobal["$LightRayPostFX::weight"]);
            pfx.setShaderConst("$decay", sGlobal["$LightRayPostFX::decay"]);
            pfx.setShaderConst("$exposure", sGlobal["$LightRayPostFX::exposure"]);
        }

        public static void initialize()
        {
            omni.dGlobal["$LightRayPostFX::brightScalar"] = 0.75;
            omni.dGlobal["$LightRayPostFX::numSamples"] = 40;
            omni.dGlobal["$LightRayPostFX::density"] = 0.94;
            omni.dGlobal["$LightRayPostFX::weight"] = 5.65;
            omni.dGlobal["$LightRayPostFX::decay"] = 1.0;
            omni.dGlobal["$LightRayPostFX::exposure"] = 0.0005;
            omni.dGlobal["$LightRayPostFX::resolutionScale"] = 1.0;

            SingletonCreator ts = new SingletonCreator("ShaderData", "LightRayOccludeShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/lightRay/lightRayOccludeP.hlsl";
            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("ShaderData", "LightRayShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/lightRay/lightRayP.hlsl";
            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("GFXStateBlockData", "LightRayStateBlock : PFX_DefaultStateBlock");
            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";
            ts["samplerStates[1]"] = "SamplerClampLinear";
            ts.Create();

            SingletonCreator LightRayPostFX = new SingletonCreator("PostEffect", "LightRayPostFX", typeof (LightRayPostEffect));
            LightRayPostFX["isEnabled"] = true;
            LightRayPostFX["allowReflectPass"] = false;

            LightRayPostFX["renderTime"] = "PFXBeforeBin";
            LightRayPostFX["renderBin"] = "EditorBin";
            LightRayPostFX["renderPriority"] = 10;

            LightRayPostFX["shader"] = "LightRayOccludeShader";
            LightRayPostFX["stateBlock"] = "LightRayStateBlock";
            LightRayPostFX["texture[0]"] = "$backBuffer";
            LightRayPostFX["texture[1]"] = "#prepass";
            LightRayPostFX["target"] = "$outTex";
            LightRayPostFX["targetFormat"] = "GFXFormatR16G16B16A16F";

            ObjectCreator final = new ObjectCreator("PostEffect", "LightRayPostFX_final");
            final["shader"] = "LightRayShader";
            final["stateBlock"] = "LightRayStateBlock";
            final["internalName"] = "final";
            final["texture[0]"] = "$inTex";
            final["texture[1]"] = "$backBuffer";
            final["target"] = "$backBuffer";
            LightRayPostFX["#1"] = final;

            LightRayPostFX.Create();
        }

    }
}