// CS1736: The expression being assigned to optional parameter `v' must be constant
// Line: 8
// Compiler options: -langversion:future

public class C
{
	static int Value = 9;

	public static void Test (int v = Value)
	{
	}
}
