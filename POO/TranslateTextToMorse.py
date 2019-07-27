def convertir_a_morse(palabra):
  lista_nombres = ['A','B','C','D','E','F','G','H','I','J','K','L', 'M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z', ' ']
  lista_morse = ['.-','-...','-.-.','-..','.','..-.','--.','....','..','.---','-.-','.-..','--','-.','--.--','---', '.--.',
  '--.-','.-.','...','_','..-','...-','.--','-..-','-.--','--..', '/']

  morse = dict(zip(lista_nombres, lista_morse))

  codigo = []
    
  for i in palabra.upper():
      try:
        codigo.append(morse[i])
      except:
        print(i, 'No es un caracter valido') 
            
  print(' '.join(codigo))

palabra = input("Digite una palabra: ")
convertir_a_morse(palabra)
