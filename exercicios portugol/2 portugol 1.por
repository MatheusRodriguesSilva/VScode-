programa
{
	
	funcao inicio()
	{
	 // VARIAVEIS
	
	     real salario = 0.0
	     real mediaSalario = 0.0
	     real totalSalario = 0.0
	     inteiro filho = 0
	     real mediaFilho = 0.0 
	     real totalFilho = 0.0
	     real maiorSalario = 0.0
	     real ate100 = 0.0
	     real total00 = 0.0
	     const inteiro HABITANTES = 20
	   

	  // ENTRADAS

	  para (inteiro x=1; x<= HABITANTES; x++){
	  	 
		escreva ("Digite o seu salario: ")
		leia (salario)
		escreva ("Quantos filhos você tem: ")
		leia (filho)
	
	// PROCESSAMENTOS
		totalSalario = totalSalario + salario
		totalFilho = totalFilho + filho
          se (salario > maiorSalario){
              maiorSalario = salario
          }
          se (salario < 100){
          	total00++  	
          }
      }   
     
      mediaSalario = totalSalario / HABITANTES
      mediaFilho = totalFilho / HABITANTES
      ate100 = (total00 / HABITANTES) * 100
      
	// SAIDAS
	escreva ("A média dos salarios é: R$", mediaSalario)
	escreva ("\nA média de filhos é: ", mediaFilho)
	escreva ("\nO maior salario é: R$", maiorSalario)
	escreva ("\nA porcentagem dos habitantes tem o salario menor que R$ 100,00 é: ", ate100)
	
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1180; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */