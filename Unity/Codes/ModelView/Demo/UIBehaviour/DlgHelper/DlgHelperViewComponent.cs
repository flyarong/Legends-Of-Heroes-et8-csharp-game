﻿
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	public  class DlgHelperViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Text E_TipText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TipText == null )
     			{
		    		this.m_E_TipText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"E_Tip");
     			}
     			return this.m_E_TipText;
     		}
     	}

		public UnityEngine.UI.Text m_E_TipText = null;
		public Transform uiTransform = null;
	}
}
