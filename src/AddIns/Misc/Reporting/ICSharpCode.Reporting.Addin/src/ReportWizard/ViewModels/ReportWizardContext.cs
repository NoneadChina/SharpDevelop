﻿/*
 * Created by SharpDevelop.
 * User: Peter Forstmeier
 * Date: 07/12/2014
 * Time: 18:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ICSharpCode.Reporting.Addin.ReportWizard.ViewModels
{
	
	public interface IWizardContext {
		
	}
	/// <summary>
	/// Description of ReportWizardViewModel.
	/// </summary>
	public class ReportWizardContext:IWizardContext
	{			
		
		
		public string Title {
			get{ return "das ist der Title";}
		}
		
		IWizardContext pageOneContext;

		public IWizardContext PageOneContext {
			get {
				return pageOneContext;
			}
			set {
				pageOneContext = value;
			}
		}
	}
}
