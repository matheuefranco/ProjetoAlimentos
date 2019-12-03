DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `listagem_produtos`()
BEGIN
select p.desc_prod, count(i.descricao_itens) as qtd_itens, sum(i.massa_restante) as qtd_total from produtos p inner join itens i
on p.idprodutos = i.idproduto
group by p.desc_prod;
END$$
DELIMITER ;
