<Query Kind="Statements" />


Console.WriteLine($"Dynamic call float");
CheckEpsilon(float.Epsilon);

Console.WriteLine($"\r\nDynamic call double");
CheckEpsilon(double.Epsilon);

Console.WriteLine($"\r\nDynamic call decimal");
CheckEpsilon(decimal.Zero);

var epsilonHashEquals = float.Epsilon.GetHashCode() == double.Epsilon.GetHashCode();
Console.WriteLine($"\r\n\r\nHashes for double and float epsilons are equals: {epsilonHashEquals}");

Console.WriteLine($"float.Equals double epsilons: {float.Epsilon.Equals(double.Epsilon)}");
Console.WriteLine($"double.Equals float epsilons: {double.Epsilon.Equals(float.Epsilon)}");
Console.WriteLine($"'==' operator: {float.Epsilon == double.Epsilon}");


void CheckEpsilon(dynamic eps)
{
	Console.WriteLine($"Epsilon value: {eps}");
	Console.WriteLine($"Hash: {eps.GetHashCode()}\r\n");
	
	Console.WriteLine($"Eps*2: {eps*2}");
	Console.WriteLine($"Eps*10: {eps*10}");
	Console.WriteLine($"Eps*Eps: {eps*eps}");

	Console.WriteLine($"Eps+Eps : {eps+eps}");
	Console.WriteLine($"Eps-Eps : {eps-eps}");
	
	Console.WriteLine($"Eps equals -Eps : {eps.Equals(-eps)}");
}

