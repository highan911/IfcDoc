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

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("0590099d-fe4d-40ba-ae80-71803e5902d0")]
	public partial struct IfcLineIndex :
		BuildingSmart.IFC.IfcGeometryResource.IfcSegmentIndexSelect
	{
		[XmlText]
		public IfcPositiveInteger Value;
	
		public IfcLineIndex(IfcPositiveInteger value)
		{
			this.Value = value;
		}
		public IfcLineIndex(IfcInteger value)
		{
			this.Value = new IfcPositiveInteger(value);
		}
	}
	
}
