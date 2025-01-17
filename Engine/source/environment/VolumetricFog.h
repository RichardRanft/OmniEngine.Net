//-----------------------------------------------------------------------------
// Copyright (c) 2014 R.G.S. - Richards Game Studio, the Netherlands
//					  http://www.richardsgamestudio.com/
//
// If you find this code useful or you are feeling particularly generous I
// would ask that you please go to http://www.richardsgamestudio.com/ then
// choose Donations from the menu on the left side and make a donation to
// Richards Game Studio. It will be highly appreciated.
//
// The MIT License:
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

#ifndef _VolumetricFog_H_
#define _VolumetricFog_H_

#ifndef _SCENEOBJECT_H_
#include "scene/sceneObject.h"
#endif
#ifndef _MATTEXTURETARGET_H_
#include "materials/matTextureTarget.h"
#endif
#ifndef _GFXSHADER_H_
#include "gfx/gfxshader.h"
#endif
#ifndef _GFXTARGET_H_
#include "gfx/gfxtarget.h"
#endif
#ifndef _GFXVERTEXBUFFER_H_
#include "gfx/gfxVertexBuffer.h"
#endif
#ifndef _TSSHAPE_H_
#include "ts/tsShape.h"
#endif

class VolumetricFog : public SceneObject
{
	typedef SceneObject Parent;

	// Maskbits for updating
	enum
	{
		VolumetricFogMask = Parent::NextFreeMask,
		FogColorMask = Parent::NextFreeMask << 1,
		FogDensityMask = Parent::NextFreeMask << 2,
		FogModulationMask = Parent::NextFreeMask << 3,
		NextFreeMask = Parent::NextFreeMask << 4
	};

	// Struct which holds the shape details
	struct meshes
	{
		F32 det_size;
		S32 sub_shape;
		S32 obj_det;
		U32 num_verts;
		GFXVertexPNTT *verts;
		Vector <GFXPrimitive> *piArray;
		Vector <U32> *indices;
	};

protected:
	// Rendertargets;
	GFXTextureTargetRef z_buf;
	NamedTexTargetRef mPrepassTarget;
	NamedTexTargetRef mDepthBufferTarget;
	NamedTexTargetRef mFrontBufferTarget;

	// Fog Modulation texture
	GFXTexHandle mTexture;

	// Shaders
	GFXShaderRef mShader;
	GFXShaderRef mPrePassShader;

	// Stateblocks
	GFXStateBlockDesc descD;
	GFXStateBlockDesc descF;
	GFXStateBlockDesc desc_preD;
	GFXStateBlockDesc desc_preF;

	GFXStateBlockRef mStateblockD;
	GFXStateBlockRef mStateblockF;
	GFXStateBlockRef mStateblock_preD;
	GFXStateBlockRef mStateblock_preF;

	// Shaderconstants
	GFXShaderConstBufferRef mShaderConsts;
	GFXShaderConstHandle *mModelViewProjSC;
	GFXShaderConstHandle *mFadeSizeSC;
	GFXShaderConstHandle *mFogColorSC;
	GFXShaderConstHandle *mFogDensitySC;
	GFXShaderConstHandle *mPreBias;
	GFXShaderConstHandle *mAccumTime;
	GFXShaderConstHandle *mIsTexturedSC;
	GFXShaderConstHandle *mModSpeedSC;
	GFXShaderConstHandle *mModStrengthSC;
	GFXShaderConstHandle *mViewPointSC;
	GFXShaderConstHandle *mTexScaleSC;
	GFXShaderConstHandle *mTexTilesSC;

	GFXShaderConstBufferRef mPPShaderConsts;
	GFXShaderConstHandle *mPPModelViewProjSC;

	// Vertex and Prim. Buffer
	GFXVertexBufferHandle<GFXVertexPNTT> mVB;
	GFXPrimitiveBufferHandle mPB;

	// Fog volume data;
	StringTableEntry mShapeName;
	ColorI mFogColor;
	F32 mFogDensity;
	bool mIgnoreWater;
	Vector<meshes> det_size;
	bool mShapeLoaded;
	F32 mPixelSize;
	F32 mFadeSize;
	U32 mCurDetailLevel;
	U32 mNumDetailLevels;
	F32 mObjSize;
	F32 mRadius;
	OrientedBox3F ColBox;
	VectorF mObjScale;
	F32 mMinDisplaySize;
	F32 mInvScale;

	// Fog Modulation data
	String mTextureName;
	bool mIsTextured;
	F32 mTexTiles;
	F32 mStrength;
	Point2F mSpeed1;
	Point2F mSpeed2;
	Point4F mSpeed;
	Point2F mTexScale;

	// Fog Rendering data
	Point3F camPos;
	Point2F mViewPoint;
	F32 mFOV;
	F32 viewDist;
	bool mIsVBDirty;
	bool mIsPBDirty;
	bool mCamInFog;

protected:
	// Protected methods
	bool onAdd();
	void onRemove();

	bool LoadShape();
	bool setupRenderer();
	void InitTexture();
	bool UpdateBuffers(U32 dl,bool force=true);

public:
	// Public methods
	VolumetricFog();
	~VolumetricFog();

	static void initPersistFields();
	virtual void inspectPostApply();

	U32  packUpdate(NetConnection *conn, U32 mask, BitStream *stream);
	void unpackUpdate(NetConnection *conn, BitStream *stream);

	void prepRenderImage(SceneRenderState* state);
	void render(ObjectRenderInst *ri, SceneRenderState *state, BaseMatInstance *overrideMat);

	// Methods for modifying & networking various fog elements
	// Used in script
	void setFogColor(ColorF color);
	void setFogColor(ColorI color);
	void setFogDensity(F32 density);
	void setFogModulation(F32 strength, Point2F speed1, Point2F speed2);

	DECLARE_CONOBJECT(VolumetricFog);

	DECLARE_CALLBACK(void, onEnterFog, (SimObjectId obj));
	DECLARE_CALLBACK(void, onLeaveFog, (SimObjectId obj));
};
#endif