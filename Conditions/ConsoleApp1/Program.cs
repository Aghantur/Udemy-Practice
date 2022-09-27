int num = 5;

int result = 0;

switch (num)
{

	case 1: result = 10;
		break;
	case 2: result = 30;
		break;
	case 3: result = 30;
        break;
	case 7: result = 50;
		break;
	default: result = 100;
		break;
}
Console.WriteLine(result);