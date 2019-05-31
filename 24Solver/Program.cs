using System;

namespace _24Solver
{
	class Program
	{
		static void Main(string[] args)
		{
			float[] input = new float[4];
			input[0] = 8;
			input[1] = 3;
			input[2] = 10;
			input[3] = 2;

			float[] output = new float[4];

			for (int e = 0; e < 4; e++)
			{
				if (e == 0)
					output[0] = input[0];
				else if (e == 1)
					output[0] = input[1];
				else if (e == 2)
					output[0] = input[2];
				else if (e == 3)
					output[0] = input[3];
				for (int f = 0; f < 4; f++)
				{
					if (f == 0)
						output[1] = input[1];
					else if (f == 1)
						output[1] = input[2];
					else if (f == 2)
						output[1] = input[3];
					else if (f == 3)
						output[1] = input[0];
					for (int g = 0; g < 4; g++)
					{
						if (g == 0)
							output[2] = input[2];
						else if (g == 1)
							output[2] = input[3];
						else if (g == 2)
							output[2] = input[0];
						else if (g == 3)
							output[2] = input[1];
						for (int h = 0; h < 4; h++)
						{
							if (h == 0)
								output[3] = input[3];
							else if (h == 1)
								output[3] = input[0];
							else if (h == 2)
								output[3] = input[1];
							else if (h == 3)
								output[3] = input[2];

							if (output[0] != output[1] && output[0] != output[2] && output[0] != output[3] &&
								output[1] != output[2] && output[1] != output[3] &&
								output[2] != output[3])
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
													ab = output[0] + output[1];
													break;
												case 1:
													ab = output[0] - output[1];
													break;
												case 2:
													ab = output[0] * output[1];
													break;
												case 3:
													ab = output[0] / output[1];
													break;
											}
											switch (k)
											{
												case 0:
													cd = output[2] + output[3];
													break;
												case 1:
													cd = output[2] - output[3];
													break;
												case 2:
													cd = output[2] * output[3];
													break;
												case 3:
													cd = output[2] / output[3];
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
												Console.WriteLine("(" + output[0] + atob + output[1] + ")" + bridge + "(" + output[2] + ctod + output[3] + ")" + " = 24");
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
