using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UIToolkit.UI;


public class SecondView : UIView {
 
	public UIList list;


	public override void ViewWillAppear (UIView sourceView = null) {
		base.ViewWillAppear (sourceView);


		//DO NOT MODIFY THE DATA
		//cell data
		List<long> data = new List<long>();
		for (int i=0; i<10; i++) data.Add(i * 100000000l);

		list.Populate(new ArrayList(data));





	}


		
}