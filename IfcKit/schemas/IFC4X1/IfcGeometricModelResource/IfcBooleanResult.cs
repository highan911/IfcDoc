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
using BuildingSmart.IFC.IfcProfileResource;
using BuildingSmart.IFC.IfcTopologyResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("74240fb6-d850-4b9a-83b8-7d82871d703f")]
	public partial class IfcBooleanResult : IfcGeometricRepresentationItem,
		BuildingSmart.IFC.IfcGeometricModelResource.IfcBooleanOperand,
		BuildingSmart.IFC.IfcGeometricModelResource.IfcCsgSelect
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcBooleanOperator _Operator;
	
		[DataMember(Order=1)] 
		[Required()]
		IfcBooleanOperand _FirstOperand;
	
		[DataMember(Order=2)] 
		[Required()]
		IfcBooleanOperand _SecondOperand;
	
	
		[Description("The Boolean operator used in the operation to create the result.")]
		public IfcBooleanOperator Operator { get { return this._Operator; } set { this._Operator = value;} }
	
		[Description("The first operand to be operated upon by the Boolean operation.")]
		public IfcBooleanOperand FirstOperand { get { return this._FirstOperand; } set { this._FirstOperand = value;} }
	
		[Description("The second operand specified for the operation.")]
		public IfcBooleanOperand SecondOperand { get { return this._SecondOperand; } set { this._SecondOperand = value;} }
	
		public new IfcDimensionCount Dim { get { return new IfcDimensionCount(); } }
	
	
	}
	
}