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

using BuildingSmart.IFC.IfcGeometricModelResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;
using BuildingSmart.IFC.IfcProfileResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("d40729e6-25f2-4bc4-81e9-9c4ce234abfd")]
	public partial class IfcPointOnSurface : IfcPoint
	{
		[DataMember(Order=0)] 
		[Required()]
		IfcSurface _BasisSurface;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		[Required()]
		IfcParameterValue _PointParameterU;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		[Required()]
		IfcParameterValue _PointParameterV;
	
	
		[Description("The surface to which the parameter values relate.")]
		public IfcSurface BasisSurface { get { return this._BasisSurface; } set { this._BasisSurface = value;} }
	
		[Description("The first parameter value of the point location.")]
		public IfcParameterValue PointParameterU { get { return this._PointParameterU; } set { this._PointParameterU = value;} }
	
		[Description("The second parameter value of the point location.")]
		public IfcParameterValue PointParameterV { get { return this._PointParameterV; } set { this._PointParameterV = value;} }
	
		public new IfcDimensionCount Dim { get { return new IfcDimensionCount(); } }
	
	
	}
	
}