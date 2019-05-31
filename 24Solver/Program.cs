using System;

namespace _24Solver
{
	struct Node
	{
		public float val;
		public string id;
	}

	class Program
	{
		static void Main(string[] args)
		{
			Node[] input = new Node[4];
			input[0].id = "satu";
			input[1].id = "dua";
			input[2].id = "tiga";
			input[3].id = "empat";

			Console.WriteLine("Input : ");
			string inputLine = Console.ReadLine();
			string[] inputs = inputLine.Split(' ');

			for(int i = 0; i < 4; i++)
				float.TryParse(inputs[i], out input[i].val);

			Node[] output = new Node[4];

			for (int e = 0; e < 4; e++)
			{
				output[0] = input[e];
				for (int f = 1; f <= 4; f++)
				{
					output[1] = input[f % 4];
					for (int g = 1; g <= 4; g++)
					{
						output[2] = input[(g + 1) % 4];
						for (int h = 1; h <= 4; h++)
						{
							output[3] = input[(h + 2) % 4];
							if (output[0].id != output[1].id && output[0].id != output[2].id && output[0].id != output[3].id &&
								output[1].id != output[2].id && output[1].id != output[3].id &&
								output[2].id != output[3].id)
							{
								for (int i = 0; i < 4; i++)
								{
									for (int j = 0; j < 4; j++)
									{
										for (int k = 0; k < 4; k++)
										{
											float ab = 0, cd = 0, hasil = 0;
											string atob = "", bridge = "", ctod = "";
											switch (i)
											{
												case 0:
													ab = output[0].val + output[1].val;
													break;
												case 1:
													ab = output[0].val - output[1].val;
													break;
												case 2:
													ab = output[0].val * output[1].val;
													break;
												case 3:
													ab = output[0].val / output[1].val;
													break;
											}
											switch (k)
											{
												case 0:
													cd = output[2].val + output[3].val;
													break;
												case 1:
													cd = output[2].val - output[3].val;
													break;
												case 2:
													cd = output[2].val * output[3].val;
													break;
												case 3:
													cd = output[2].val / output[3].val;
													break;
											}
											switch (j)
											{
												case 0:
													hasil = ab + cd;
													break;
												case 1:
													hasil = ab - cd;
													break;
												case 2:
													hasil = ab * cd;
													break;
												case 3:
													if (cd != 0)
														hasil = ab / cd;
													else
														hasil = 0;
													break;
											}
											if (hasil == 24)
											{
												switch (i)
												{
													case 0:
														atob = " + ";
														break;
													case 1:
														atob = " - ";
														break;
													case 2:
														atob = " * ";
														break;
													case 3:
														atob = " / ";
														break;
												}
												switch (j)
												{
													case 0:
														bridge = " + ";
														break;
													case 1:
														bridge = " - ";
														break;
													case 2:
														bridge = " * ";
														break;
													case 3:
														bridge = " / ";
														break;
												}
												switch (k)
												{
													case 0:
														ctod = " + ";
														break;
													case 1:
														ctod = " - ";
														break;
													case 2:
														ctod = " * ";
														break;
													case 3:
														ctod = " / ";
														break;
												}
												Console.WriteLine("(" + output[0].val + atob + output[1].val + ")" + bridge + "(" + output[2].val + ctod + output[3].val + ")" + " = 24");
												break;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			Console.WriteLine("Finished");
			Console.ReadKey();
		}
	}
}
