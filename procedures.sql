DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `lista_itens_consumo_por_data`()
SELECT `itens`.`iditens`,`itens`.`descricao_itens`,`itens`.`massa_restante`,`itens`.`massa`,`itens`.`idproduto`,DATE_FORMAT(`consumo`.`data`, "%d %M %Y") as data, `produtos`.`desc_prod`, (`itens`.`massa`-`itens`.`massa_restante`) as consumo
FROM `sisalimentos`.`itens`
INNER JOIN
`sisalimentos`.`produtos` ON `sisalimentos`.`produtos`.idprodutos = `sisalimentos`.`itens`.idproduto
INNER JOIN
`sisalimentos`.`consumo` ON `sisalimentos`.`itens`.iditens = `sisalimentos`.`consumo`.iditem ORDER BY data$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `lista_itens_consumo_por_periodo`(IN `date_st` DATE, IN `date_end` DATE, IN `idprod` INT)
SELECT `itens`.`iditens`,`itens`.`descricao_itens`,`itens`.`massa_restante`,`itens`.`massa`,`itens`.`idproduto`,DATE_FORMAT(`consumo`.`data`, "%d %M %Y") as data, `produtos`.`desc_prod`, (`itens`.`massa`-`itens`.`massa_restante`) as consumo
FROM `sisalimentos`.`itens`
INNER JOIN
`sisalimentos`.`produtos` ON `sisalimentos`.`produtos`.idprodutos = `sisalimentos`.`itens`.idproduto
INNER JOIN
`sisalimentos`.`consumo` ON `sisalimentos`.`itens`.iditens = `sisalimentos`.`consumo`.iditem 
WHERE (`consumo`.`data` BETWEEN date_st AND date_end) AND idprod = `sisalimentos`.`itens`.idproduto
ORDER BY data$$
DELIMITER ;
