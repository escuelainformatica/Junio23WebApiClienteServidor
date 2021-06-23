# Junio23WebApiClienteServidor



## OpenAPI



```yaml
openapi: 3.0.0
info:
  version: '1.0'
  title: ejemplo
servers:
  - url: 'http://localhost:14695' # servidor web
paths:
    /api/Ejemplo/Resultado: # primera funcion
        post:
            summary: 'comentario'
            operationId: resultado  # identificador unico (no debe haber otro operationId)
            responses:
                '200':  # lo que pasa cuando se conecta correctamente
                    description: 'comentario'
                    headers:
                        x-next:
                            description: A link to the next page of responses
                            schema:
                                type: string
                    content:  # la respuesta.
                        application/json:  
                            schema:
                                $ref: '#/components/schemas/User' #ea definicion esta al final de este documento
                default:  # si el comando falla.
                    description: Unexpected error1
                    content:
                        application/json:
                            schema:
                                $ref: '#/components/schemas/Error'
    /api/Ejemplo/Sumar2: #segunda funcion
        post:
            summary: 'Sample endpoint: Returns details about a particular user'
            operationId: Sumar2
            requestBody: #valores de entrada (el cuerpo)
                content:
                    application/json:
                        schema:      
                            type: object
                            properties:
                                N1:
                                    type: integer
                                N2:
                                    type: integer
            responses:
                "200":
                    description: 'Sample response: Details about a user by ID'
                    headers:
                        x-next:
                            description: A link to the next page of responses
                            schema:
                                type: string
                    content:
                        application/json:
                            schema:
                                type: integer
                default:
                    description: Unexpected error2
                    content:
                        application/json:
                            schema:
                                $ref: '#/components/schemas/Error'                
components:
  schemas:
    Total:
        type: integer
    User:
      type: array
      items: 
          type: string
    Error:
      type: object
      required:
        - code
        - message
      properties:
        code:
          type: integer
          format: int32
        message:
          type: string
```

