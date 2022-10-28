﻿namespace CL.Core.InputModel;

public class AlteraCliente : NovoCliente
{
    /// <summary>
    /// Id do cliente que se deseja alterar os dados
    /// </summary>
    /// <example>1</example>
    public int Id { get; set; }
}
