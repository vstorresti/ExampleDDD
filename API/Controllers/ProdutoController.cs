using System;
using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;

        public ProdutoController(IApplicationServiceProduto applicationServiceProduto)
        {
            _applicationServiceProduto = applicationServiceProduto;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceProduto.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceProduto.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto produtoDTO)
        {
            try
            {
                if(produtoDTO == null)
                    return NotFound();
                
                _applicationServiceProduto.Add(produtoDTO);
                return Ok("Produto cadastrado com sucesso!");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto produtoDto)
        {
            try
            {
               if(produtoDto == null) 
                    return NotFound();
                
                _applicationServiceProduto.Update(produtoDto);
                return Ok("Produto atualizado com sucesso!");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if(produtoDto == null)
                    return NotFound();
                
                _applicationServiceProduto.Remove(produtoDto);
                return Ok("Produto removido com sucesso!");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        
    }
}