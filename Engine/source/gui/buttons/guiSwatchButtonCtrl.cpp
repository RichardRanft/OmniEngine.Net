//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

#include "platform/platform.h"
#include "gui/buttons/guiSwatchButtonCtrl.h"

#include "console/console.h"
#include "console/consoleTypes.h"
#include "console/engineAPI.h"
#include "gfx/gfxDevice.h"
#include "gfx/gfxDrawUtil.h"
#include "gui/core/guiCanvas.h"
#include "gui/core/guiDefaultControlRender.h"

IMPLEMENT_CONOBJECT( GuiSwatchButtonCtrl );

ConsoleDocClass( GuiSwatchButtonCtrl,
   "@brief A button that is used to represent color; often used in correlation with a color picker.\n\n"
   
   "A swatch button is a push button that uses its color field to designate the color drawn over an image, on top of a button.\n\n"
   
   "The color itself is a float value stored inside the GuiSwatchButtonCtrl::color field. The texture path that represents\n"
   "the image underlying the color is stored inside the GuiSwatchButtonCtrl::gridBitmap field.\n"
   "The default value assigned toGuiSwatchButtonCtrl::color is \"1 1 1 1\"( White ). The default/fallback image assigned to \n"
   "GuiSwatchButtonCtrl::gridBitmap is \"tools/gui/images/transp_grid\".\n\n"
   
   "@tsexample\n"
   "// Create a GuiSwatchButtonCtrl that calls randomFunction with its current color when clicked\n"
   "%swatchButton = new GuiSwatchButtonCtrl()\n"
   "{\n"
   "   profile = \"GuiInspectorSwatchButtonProfile\";\n"
   "   command = \"randomFunction( $ThisControl.color );\";\n"
   "};\n"
   "@endtsexample\n\n"
   
   "@ingroup GuiButtons"
);

//-----------------------------------------------------------------------------

GuiSwatchButtonCtrl::GuiSwatchButtonCtrl()
 : mSwatchColor( 1, 1, 1, 1 )
{
   mButtonText = StringTable->insert( "" );   
   setExtent(140, 30);
   
   static StringTableEntry sProfile = StringTable->insert( "profile" );
   setDataField( sProfile, NULL, "GuiInspectorSwatchButtonProfile" );

   mGridBitmap = "tools/gui/images/transp_grid";
}

void GuiSwatchButtonCtrl::initPersistFields()
{
   addField( "color", TypeColorF, Offset( mSwatchColor, GuiSwatchButtonCtrl ), "The foreground color of GuiSwatchButtonCtrl" );

   addField( "gridBitmap", TypeString, Offset( mGridBitmap, GuiSwatchButtonCtrl ), "The bitmap used for the transparent grid" );
   
   Parent::initPersistFields();

   // Copyright (C) 2013 WinterLeaf Entertainment LLC.
   //  @Copyright start

   removeField( "controlFontColor");

   removeField("backgroundColor" );

   removeField("controlFillColor");

   removeField("contextFillColor");

   removeField( "contextFontColor" );

   removeField( "contextBackColor" );

   // @Copyright end
}

bool GuiSwatchButtonCtrl::onWake()
{      
   if ( !Parent::onWake() )
      return false;

   if ( mGrid.isNull() )
      mGrid.set( mGridBitmap, &GFXDefaultGUIProfile, avar("%s() - mGrid (line %d)", __FUNCTION__, __LINE__) );

   return true;
}

// Copyright (C) 2013 WinterLeaf Entertainment LLC.
//  @Copyright start

void GuiSwatchButtonCtrl::copyProfileSettings()
{
   if(mSwatchColor && !mProfileSettingsCopied)
   {
      mSwatchColorCopy = mSwatchColor;
      Parent::copyProfileSettings();
   }
}

void GuiSwatchButtonCtrl::applyProfileSettings()
{
   Parent::applyProfileSettings();
   if(mSwatchColor)
      mSwatchColor.alpha = mSwatchColorCopy.alpha * mRenderAlpha;
}

void GuiSwatchButtonCtrl::resetProfileSettings()
{
   mSwatchColor = mSwatchColorCopy;
   Parent::resetProfileSettings();
}

void GuiSwatchButtonCtrl::onStaticModified( const char *slotName, const char *newValue )
{
   if( !dStricmp( slotName, "color" ) )
   {
      ColorF color(1, 0, 0, 1);
      dSscanf( newValue, "%f %f %f %f", &color.red, &color.green, &color.blue, &color.alpha );
   
      mSwatchColorCopy = color;
   }
}
// @Copyright end

void GuiSwatchButtonCtrl::onRender( Point2I offset, const RectI &updateRect )
{
   bool highlight = mMouseOver;

   ColorI backColor   = mSwatchColor;
   ColorI borderColor = mActive ? ( highlight ? mProfile->mBorderColorHL : mProfile->mBorderColor ) : mProfile->mBorderColorNA;

   RectI renderRect( offset, getExtent() );
   if ( !highlight )
      renderRect.inset( 1, 1 );      

   GFXDrawUtil *drawer = GFX->getDrawUtil();
   //drawer->clearBitmapModulation();     // Copyright (C) 2013 WinterLeaf Entertainment LLC.

   // Draw background transparency grid texture...
   if ( mGrid.isValid() )
      drawer->drawBitmapStretch( mGrid, renderRect );

   // Draw swatch color as fill...
   drawer->drawRectFill( renderRect, mSwatchColor );

   // Draw any borders...
   drawer->drawRect( renderRect, borderColor );
}

//-----------------------------------------------------------------------------

DefineEngineMethod( GuiSwatchButtonCtrl, setColor, void, ( const char* newColor ),,
   "Set the color of the swatch control.\n"
   "@param newColor The new color string given to the swatch control in float format \"r g b a\".\n"
   "@note It's also important to note that when setColor is called causes\n"
   "the control's altCommand field to be executed." )
{
   object->setField( "color", newColor );
   object->execAltConsoleCallback();
}


















































//---------------DNTC AUTO-GENERATED---------------//
#include <vector>

#include <string>

#include "core/strings/stringFunctions.h"

//---------------DO NOT MODIFY CODE BELOW----------//

extern "C" __declspec(dllexport) void  __cdecl wle_fnGuiSwatchButtonCtrl_setColor(char * x__object, char * x__newColor)
{
GuiSwatchButtonCtrl* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
const char* newColor = (const char*)x__newColor;
{
   object->setField( "color", newColor );
   object->execAltConsoleCallback();
}
}
//---------------END DNTC AUTO-GENERATED-----------//

