class homework2{
	static void Main(){
		bool row = false;
		for (int i=0; i<8; i++){
			if (row){
				string row2 = "";
				bool X = false;
				for (int j = 0; j < 8; j++) {
					if (X)
						row2 += "X";
					else
						row2 += "O";
					X = !X;
				}
				System.Console.WriteLine (row2);
			}
			else {
				string row1 = "";
				bool X = true;
				for (int j = 0; j < 8; j++) {
					if (X)
						row1 += "X";
					else
						row1 += "O";
					X = !X;
				}
				System.Console.WriteLine(row1);
			}
			row = !row;
		}
	}
}