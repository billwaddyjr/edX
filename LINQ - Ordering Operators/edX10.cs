using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;


public class mod10{
	public static void Main(){
		double[] doubles = {1.7, 2.3, 1.9, 4.1, 2.9};
		
		var sortedDoubles = doubles.OrderByDescending(x => x);
		foreach (var d in sortedDoubles)
		{
			Console.WriteLine(d);
		}
	}
}
