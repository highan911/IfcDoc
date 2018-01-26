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


namespace BuildingSmart.IFC.IfcMeasureResource
{
	[Guid("3a9ab3fb-6071-423b-afb3-b5d134501151")]
	public partial struct IfcPositiveLengthMeasure :
		BuildingSmart.IFC.IfcPresentationAppearanceResource.IfcHatchLineDistanceSelect,
		BuildingSmart.IFC.IfcMeasureResource.IfcMeasureValue,
		BuildingSmart.IFC.IfcPresentationAppearanceResource.IfcSizeSelect
	{
		[XmlText]
		public IfcLengthMeasure Value;
	
		public IfcPositiveLengthMeasure(IfcLengthMeasure value)
		{
			this.Value = value;
		}
		public IfcPositiveLengthMeasure(Double value)
		{
			this.Value = new IfcLengthMeasure(value);
		}
	}
	
}
