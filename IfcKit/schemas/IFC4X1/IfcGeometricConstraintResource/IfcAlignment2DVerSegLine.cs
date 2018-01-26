// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometricConstraintResource
{
	[Guid("bedbb949-253b-4105-a85b-41acd20ec5d7")]
	public partial class IfcAlignment2DVerSegLine : IfcAlignment2DVerticalSegment
	{
	
		public IfcAlignment2DVerSegLine()
		{
		}
	
		public IfcAlignment2DVerSegLine(IfcBoolean? __TangentialContinuity, IfcLabel? __StartTag, IfcLabel? __EndTag, IfcLengthMeasure __StartDistAlong, IfcPositiveLengthMeasure __HorizontalLength, IfcLengthMeasure __StartHeight, IfcRatioMeasure __StartGradient)
			: base(__TangentialContinuity, __StartTag, __EndTag, __StartDistAlong, __HorizontalLength, __StartHeight, __StartGradient)
		{
		}
	
	
	}
	
}
