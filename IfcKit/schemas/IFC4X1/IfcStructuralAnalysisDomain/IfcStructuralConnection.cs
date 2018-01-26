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

using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcStructuralLoadResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("d4640db1-7b55-4f79-8ba6-05b016369801")]
	public abstract partial class IfcStructuralConnection : IfcStructuralItem
	{
		[DataMember(Order=0)] 
		[XmlElement]
		IfcBoundaryCondition _AppliedCondition;
	
		[InverseProperty("RelatedStructuralConnection")] 
		[MinLength(1)]
		ISet<IfcRelConnectsStructuralMember> _ConnectsStructuralMembers = new HashSet<IfcRelConnectsStructuralMember>();
	
	
		public IfcStructuralConnection()
		{
		}
	
		public IfcStructuralConnection(IfcGloballyUniqueId __GlobalId, IfcOwnerHistory __OwnerHistory, IfcLabel? __Name, IfcText? __Description, IfcLabel? __ObjectType, IfcObjectPlacement __ObjectPlacement, IfcProductRepresentation __Representation, IfcBoundaryCondition __AppliedCondition)
			: base(__GlobalId, __OwnerHistory, __Name, __Description, __ObjectType, __ObjectPlacement, __Representation)
		{
			this._AppliedCondition = __AppliedCondition;
		}
	
		[Description(@"Optional boundary conditions which define support conditions of this connection object, given in local coordinate directions of the connection object.  If left unspecified, the connection object is assumed to have no supports besides being connected with members.")]
		public IfcBoundaryCondition AppliedCondition { get { return this._AppliedCondition; } set { this._AppliedCondition = value;} }
	
		[Description("References to the IfcRelConnectsStructuralMembers relationship by which structura" +
	    "l members can be associated to structural connections.")]
		public ISet<IfcRelConnectsStructuralMember> ConnectsStructuralMembers { get { return this._ConnectsStructuralMembers; } }
	
	
	}
	
}
