int lado_1 = Console.ReadLine();
int lado_2 = Console.ReadLine();
int lado_3 = Console.ReadLine();

if(lado_1 == lado_2 && lado_1 == lado_3){
    Console.WriteLine("O triângulo é Equilátero");
}
else if(lado_1 == lado_2 || lado_1 == lado_3){
    Console.WriteLine("O triângulo é Isóceles");
}
else{
    Console.WriteLine("O triângulo é Escaleno");
}

//1.0
//2.0
//3.0
//4.0
//3.1
//3.2
//2.1
//2.2