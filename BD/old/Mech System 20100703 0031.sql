-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.1.35-community


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema mechsystem
--

CREATE DATABASE IF NOT EXISTS mechsystem;
USE mechsystem;

--
-- Temporary table structure for view `clientespf`
--
DROP TABLE IF EXISTS `clientespf`;
DROP VIEW IF EXISTS `clientespf`;
CREATE TABLE `clientespf` (
  `id` int(11),
  `nome` varchar(50),
  `apelido` varchar(50),
  `rg` varchar(12),
  `cpf` varchar(15),
  `cep` varchar(9),
  `logradouro` varchar(45),
  `numero` varchar(10),
  `bairro` varchar(45),
  `cidade` varchar(45),
  `estado` char(2),
  `datanasc` date,
  `nomepai` varchar(50),
  `nomemae` varchar(50),
  `email` varchar(50),
  `telefone1` varchar(13),
  `ramal1` varchar(10),
  `telefone2` varchar(13),
  `ramal2` varchar(10),
  `obs` varchar(200),
  `c_status` varchar(30)
);

--
-- Temporary table structure for view `clientespj`
--
DROP TABLE IF EXISTS `clientespj`;
DROP VIEW IF EXISTS `clientespj`;
CREATE TABLE `clientespj` (
  `id` int(11),
  `razaosocial` varchar(50),
  `nomefantasia` varchar(50),
  `ie` varchar(15),
  `cnpj` varchar(18),
  `cep` varchar(9),
  `logradouro` varchar(45),
  `numero` varchar(10),
  `bairro` varchar(45),
  `cidade` varchar(45),
  `estado` char(2),
  `email` varchar(50),
  `telefone1` varchar(13),
  `ramal1` varchar(10),
  `telefone2` varchar(13),
  `ramal2` varchar(10),
  `obs` varchar(200),
  `c_status` varchar(30)
);

--
-- Temporary table structure for view `funcaofunc`
--
DROP TABLE IF EXISTS `funcaofunc`;
DROP VIEW IF EXISTS `funcaofunc`;
CREATE TABLE `funcaofunc` (
  `idFunc` int(11),
  `nomeFunc` varchar(45),
  `funcao` varchar(45)
);

--
-- Definition of table `carro`
--

DROP TABLE IF EXISTS `carro`;
CREATE TABLE `carro` (
  `placa` varchar(8) NOT NULL,
  `marca` varchar(20) NOT NULL,
  `modelo` varchar(20) NOT NULL,
  `cor` varchar(20) NOT NULL,
  `ano` varchar(4) DEFAULT NULL,
  `Clientes_id` int(11) NOT NULL,
  PRIMARY KEY (`placa`),
  KEY `fk_Carro_Clientes1` (`Clientes_id`),
  CONSTRAINT `FK_carro_1` FOREIGN KEY (`Clientes_id`) REFERENCES `clientes` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `carro`
--

/*!40000 ALTER TABLE `carro` DISABLE KEYS */;
/*!40000 ALTER TABLE `carro` ENABLE KEYS */;


--
-- Definition of table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cep` varchar(9) DEFAULT NULL,
  `logradouro` varchar(45) DEFAULT NULL,
  `numero` varchar(10) DEFAULT NULL,
  `bairro` varchar(45) DEFAULT NULL,
  `cidade` varchar(45) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `telefone1` varchar(13) DEFAULT NULL,
  `ramal1` varchar(10) DEFAULT NULL,
  `telefone2` varchar(13) DEFAULT NULL,
  `ramal2` varchar(10) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `PessoaFisica_cpf` varchar(15) DEFAULT NULL,
  `PessoaJuridica_cnpj` varchar(18) DEFAULT NULL,
  `obs` varchar(200) DEFAULT NULL,
  `c_status` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Clientes_PessoaFisica1` (`PessoaFisica_cpf`),
  KEY `fk_Clientes_PessoaJuridica1` (`PessoaJuridica_cnpj`),
  CONSTRAINT `fk_Clientes_PessoaFisica1` FOREIGN KEY (`PessoaFisica_cpf`) REFERENCES `pessoafisica` (`cpf`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `fk_Clientes_PessoaJuridica1` FOREIGN KEY (`PessoaJuridica_cnpj`) REFERENCES `pessoajuridica` (`cnpj`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `clientes`
--

/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;


--
-- Definition of table `cod_barras`
--

DROP TABLE IF EXISTS `cod_barras`;
CREATE TABLE `cod_barras` (
  `ean13` varchar(13) NOT NULL DEFAULT '',
  `idproduto` int(11) NOT NULL,
  `embalagem` varchar(10) DEFAULT NULL,
  `unidade` int(11) DEFAULT NULL,
  PRIMARY KEY (`ean13`),
  KEY `cod_barras_ibfk_1` (`idproduto`),
  CONSTRAINT `cod_barras_ibfk_1` FOREIGN KEY (`idproduto`) REFERENCES `produtos` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cod_barras`
--

/*!40000 ALTER TABLE `cod_barras` DISABLE KEYS */;
/*!40000 ALTER TABLE `cod_barras` ENABLE KEYS */;


--
-- Definition of table `compra`
--

DROP TABLE IF EXISTS `compra`;
CREATE TABLE `compra` (
  `nf` int(11) NOT NULL,
  `total` float DEFAULT NULL,
  `datacompra` date DEFAULT NULL,
  PRIMARY KEY (`nf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `compra`
--

/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
/*!40000 ALTER TABLE `compra` ENABLE KEYS */;


--
-- Definition of table `finalizadoras`
--

DROP TABLE IF EXISTS `finalizadoras`;
CREATE TABLE `finalizadoras` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `finalizadoras`
--

/*!40000 ALTER TABLE `finalizadoras` DISABLE KEYS */;
/*!40000 ALTER TABLE `finalizadoras` ENABLE KEYS */;


--
-- Definition of table `fornecedor`
--

DROP TABLE IF EXISTS `fornecedor`;
CREATE TABLE `fornecedor` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `razaosocial` varchar(50) DEFAULT NULL,
  `nomefantasia` varchar(50) DEFAULT NULL,
  `cnpj` varchar(18) DEFAULT NULL,
  `ie` varchar(15) DEFAULT NULL,
  `cep` varchar(9) DEFAULT NULL,
  `logradouro` varchar(50) DEFAULT NULL,
  `numero` varchar(10) DEFAULT NULL,
  `bairro` varchar(45) DEFAULT NULL,
  `cidade` varchar(45) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `telefone1` varchar(13) DEFAULT NULL,
  `ramal1` varchar(10) DEFAULT NULL,
  `telefone2` varchar(13) DEFAULT NULL,
  `ramal2` varchar(10) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `obs` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fornecedor`
--

/*!40000 ALTER TABLE `fornecedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `fornecedor` ENABLE KEYS */;


--
-- Definition of table `funcao`
--

DROP TABLE IF EXISTS `funcao`;
CREATE TABLE `funcao` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `funcao`
--

/*!40000 ALTER TABLE `funcao` DISABLE KEYS */;
/*!40000 ALTER TABLE `funcao` ENABLE KEYS */;


--
-- Definition of table `item_compra`
--

DROP TABLE IF EXISTS `item_compra`;
CREATE TABLE `item_compra` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `qtde` float DEFAULT NULL,
  `total` float DEFAULT NULL,
  `compra_nf` int(11) NOT NULL,
  `Fornecedor_has_Produtos_Produtos_id` int(11) NOT NULL,
  `Fornecedor_has_Produtos_Fornecedor_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Fornecedor_has_Produtos_has_compra_Fornecedor_has_Produtos1` (`Fornecedor_has_Produtos_Fornecedor_id`,`Fornecedor_has_Produtos_Produtos_id`),
  KEY `fk_Fornecedor_has_Produtos_has_compra_compra1` (`compra_nf`),
  CONSTRAINT `fk_Fornecedor_has_Produtos_has_compra_compra1` FOREIGN KEY (`compra_nf`) REFERENCES `compra` (`nf`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Fornecedor_has_Produtos_has_compra_Fornecedor_has_Produtos1` FOREIGN KEY (`Fornecedor_has_Produtos_Fornecedor_id`, `Fornecedor_has_Produtos_Produtos_id`) REFERENCES `r_forn_prod` (`Fornecedor_id`, `Produtos_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `item_compra`
--

/*!40000 ALTER TABLE `item_compra` DISABLE KEYS */;
/*!40000 ALTER TABLE `item_compra` ENABLE KEYS */;


--
-- Definition of table `mecanico`
--

DROP TABLE IF EXISTS `mecanico`;
CREATE TABLE `mecanico` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `cpf` varchar(15) DEFAULT NULL,
  `rg` varchar(12) DEFAULT NULL,
  `logradouro` varchar(45) DEFAULT NULL,
  `numero` varchar(10) DEFAULT NULL,
  `bairro` varchar(45) DEFAULT NULL,
  `cidade` varchar(45) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `cep` varchar(9) DEFAULT NULL,
  `datanasc` date DEFAULT NULL,
  `dataadmi` date DEFAULT NULL,
  `salario` decimal(10,2) DEFAULT NULL,
  `telefone` varchar(13) DEFAULT NULL,
  `celular` varchar(13) DEFAULT NULL,
  `idFuncao` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idFuncao` (`idFuncao`),
  CONSTRAINT `mecanico_ibfk_1` FOREIGN KEY (`idFuncao`) REFERENCES `funcao` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mecanico`
--

/*!40000 ALTER TABLE `mecanico` DISABLE KEYS */;
/*!40000 ALTER TABLE `mecanico` ENABLE KEYS */;


--
-- Definition of table `mov_estoque`
--

DROP TABLE IF EXISTS `mov_estoque`;
CREATE TABLE `mov_estoque` (
  `idMov` int(11) NOT NULL AUTO_INCREMENT,
  `descricaoMov` varchar(200) DEFAULT NULL,
  `tipoMov` varchar(50) NOT NULL,
  `qtdeMov` int(11) NOT NULL,
  `dataMov` datetime NOT NULL,
  `usuarioMov` varchar(50) NOT NULL,
  `idProduto` int(11) NOT NULL,
  PRIMARY KEY (`idMov`),
  KEY `idProduto` (`idProduto`),
  CONSTRAINT `mov_estoque_ibfk_1` FOREIGN KEY (`idProduto`) REFERENCES `produtos` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mov_estoque`
--

/*!40000 ALTER TABLE `mov_estoque` DISABLE KEYS */;
/*!40000 ALTER TABLE `mov_estoque` ENABLE KEYS */;


--
-- Definition of table `os`
--

DROP TABLE IF EXISTS `os`;
CREATE TABLE `os` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `os_data` date DEFAULT NULL,
  `responsavel` varchar(40) DEFAULT NULL,
  `telefone` varchar(40) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  `os_status` varchar(40) DEFAULT NULL,
  `placaveiculo` varchar(8) NOT NULL,
  `idfinalizadora` int(11) DEFAULT NULL,
  `idmecanico` int(11) DEFAULT NULL,
  `defeito` varchar(300) DEFAULT NULL,
  `rel_tecnico` varchar(300) DEFAULT NULL,
  `os_datasaida` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `placaveiculo` (`placaveiculo`),
  KEY `idfinalizadora` (`idfinalizadora`),
  KEY `idmecanico` (`idmecanico`),
  CONSTRAINT `os_ibfk_1` FOREIGN KEY (`placaveiculo`) REFERENCES `carro` (`placa`) ON DELETE CASCADE,
  CONSTRAINT `os_ibfk_2` FOREIGN KEY (`idfinalizadora`) REFERENCES `finalizadoras` (`id`),
  CONSTRAINT `os_ibfk_3` FOREIGN KEY (`idmecanico`) REFERENCES `mecanico` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `os`
--

/*!40000 ALTER TABLE `os` DISABLE KEYS */;
/*!40000 ALTER TABLE `os` ENABLE KEYS */;


--
-- Definition of table `os_produto`
--

DROP TABLE IF EXISTS `os_produto`;
CREATE TABLE `os_produto` (
  `idItem` int(11) NOT NULL,
  `idOs` int(11) NOT NULL,
  `qtde` int(11) NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  `idProduto` int(11) NOT NULL,
  `estado` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idItem`,`idOs`),
  KEY `idProduto` (`idProduto`),
  KEY `FK_os_produto_2` (`idOs`),
  CONSTRAINT `FK_os_produto_2` FOREIGN KEY (`idOs`) REFERENCES `os` (`id`) ON DELETE CASCADE,
  CONSTRAINT `os_produto_ibfk_1` FOREIGN KEY (`idProduto`) REFERENCES `produtos` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `os_produto`
--

/*!40000 ALTER TABLE `os_produto` DISABLE KEYS */;
/*!40000 ALTER TABLE `os_produto` ENABLE KEYS */;


--
-- Definition of table `os_servico`
--

DROP TABLE IF EXISTS `os_servico`;
CREATE TABLE `os_servico` (
  `idItem` int(11) NOT NULL,
  `idOs` int(11) NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  `idServico` int(11) NOT NULL,
  `estado` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idItem`,`idOs`),
  KEY `idServico` (`idServico`),
  KEY `FK_os_servico_2` (`idOs`),
  CONSTRAINT `FK_os_servico_2` FOREIGN KEY (`idOs`) REFERENCES `os` (`id`) ON DELETE CASCADE,
  CONSTRAINT `os_servico_ibfk_1` FOREIGN KEY (`idServico`) REFERENCES `servico` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `os_servico`
--

/*!40000 ALTER TABLE `os_servico` DISABLE KEYS */;
/*!40000 ALTER TABLE `os_servico` ENABLE KEYS */;


--
-- Definition of table `pessoafisica`
--

DROP TABLE IF EXISTS `pessoafisica`;
CREATE TABLE `pessoafisica` (
  `cpf` varchar(15) NOT NULL,
  `rg` varchar(12) DEFAULT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `apelido` varchar(50) DEFAULT NULL,
  `datanasc` date DEFAULT NULL,
  `nomepai` varchar(50) DEFAULT NULL,
  `nomemae` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pessoafisica`
--

/*!40000 ALTER TABLE `pessoafisica` DISABLE KEYS */;
/*!40000 ALTER TABLE `pessoafisica` ENABLE KEYS */;


--
-- Definition of table `pessoajuridica`
--

DROP TABLE IF EXISTS `pessoajuridica`;
CREATE TABLE `pessoajuridica` (
  `cnpj` varchar(18) NOT NULL DEFAULT '',
  `ie` varchar(15) DEFAULT NULL,
  `razaosocial` varchar(50) DEFAULT NULL,
  `nomefantasia` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`cnpj`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pessoajuridica`
--

/*!40000 ALTER TABLE `pessoajuridica` DISABLE KEYS */;
/*!40000 ALTER TABLE `pessoajuridica` ENABLE KEYS */;


--
-- Definition of table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
CREATE TABLE `produtos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(45) NOT NULL,
  `descricaoresumida` varchar(45) DEFAULT NULL,
  `unidade` int(11) DEFAULT NULL,
  `margemlucro` decimal(10,2) DEFAULT NULL,
  `venda` decimal(10,2) DEFAULT NULL,
  `estoque` int(11) DEFAULT NULL,
  `marca` varchar(40) DEFAULT NULL,
  `idfornecedor` int(11) DEFAULT NULL,
  `estoqueminimo` int(11) DEFAULT NULL,
  `custo` decimal(10,2) DEFAULT NULL,
  `embalagem` varchar(10) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  `estado_estoque` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_produtos_1` (`idfornecedor`),
  CONSTRAINT `FK_produtos_1` FOREIGN KEY (`idfornecedor`) REFERENCES `fornecedor` (`id`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `produtos`
--

/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;


--
-- Definition of table `r_forn_prod`
--

DROP TABLE IF EXISTS `r_forn_prod`;
CREATE TABLE `r_forn_prod` (
  `Fornecedor_id` int(11) NOT NULL,
  `Produtos_id` int(11) NOT NULL,
  `custo` float NOT NULL,
  PRIMARY KEY (`Fornecedor_id`,`Produtos_id`),
  KEY `fk_Fornecedor_has_Produtos_Fornecedor` (`Fornecedor_id`),
  KEY `fk_Fornecedor_has_Produtos_Produtos` (`Produtos_id`),
  CONSTRAINT `fk_Fornecedor_has_Produtos_Fornecedor` FOREIGN KEY (`Fornecedor_id`) REFERENCES `fornecedor` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Fornecedor_has_Produtos_Produtos` FOREIGN KEY (`Produtos_id`) REFERENCES `produtos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `r_forn_prod`
--

/*!40000 ALTER TABLE `r_forn_prod` DISABLE KEYS */;
/*!40000 ALTER TABLE `r_forn_prod` ENABLE KEYS */;


--
-- Definition of table `servico`
--

DROP TABLE IF EXISTS `servico`;
CREATE TABLE `servico` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(500) NOT NULL,
  `valor` decimal(10,2) DEFAULT NULL,
  `detalhes` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `servico`
--

/*!40000 ALTER TABLE `servico` DISABLE KEYS */;
/*!40000 ALTER TABLE `servico` ENABLE KEYS */;


--
-- Definition of table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `senha` char(6) NOT NULL,
  `perfil` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usuarios`
--

/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`id`,`nome`,`senha`,`perfil`) VALUES 
 (1,'MLM','4625','ADMINISTRADOR'),
 (2,'FELIPE','3422','ADMINISTRADOR'),
 (3,'PRISCILA','1Q2W3E','ADMINISTRADOR');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;


--
-- Definition of procedure `sp_cad_ean`
--

DROP PROCEDURE IF EXISTS `sp_cad_ean`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_cad_ean`(p_ean13 VARCHAR(13), p_idproduto INT,
p_emb VARCHAR(10), p_unid INT)
BEGIN
      INSERT INTO cod_barras
      VALUES (p_ean13, p_idproduto, p_emb, p_unid);
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of procedure `sp_estado_estoque`
--

DROP PROCEDURE IF EXISTS `sp_estado_estoque`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_estado_estoque`()
BEGIN
      UPDATE produtos SET estado_estoque =
      CASE
      WHEN estoque > estoqueminimo THEN 'DISPONIVEL'
      WHEN estoque < estoqueminimo THEN 'ABAIXO DO MINIMO'
      ELSE 'MINIMO'
      END;
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;

--
-- Definition of view `clientespf`
--

DROP TABLE IF EXISTS `clientespf`;
DROP VIEW IF EXISTS `clientespf`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `clientespf` AS select `cli`.`id` AS `id`,`pf`.`nome` AS `nome`,`pf`.`apelido` AS `apelido`,`pf`.`rg` AS `rg`,`pf`.`cpf` AS `cpf`,`cli`.`cep` AS `cep`,`cli`.`logradouro` AS `logradouro`,`cli`.`numero` AS `numero`,`cli`.`bairro` AS `bairro`,`cli`.`cidade` AS `cidade`,`cli`.`estado` AS `estado`,`pf`.`datanasc` AS `datanasc`,`pf`.`nomepai` AS `nomepai`,`pf`.`nomemae` AS `nomemae`,`cli`.`email` AS `email`,`cli`.`telefone1` AS `telefone1`,`cli`.`ramal1` AS `ramal1`,`cli`.`telefone2` AS `telefone2`,`cli`.`ramal2` AS `ramal2`,`cli`.`obs` AS `obs`,`cli`.`c_status` AS `c_status` from (`pessoafisica` `pf` join `clientes` `cli` on((`pf`.`cpf` = `cli`.`PessoaFisica_cpf`))) order by `pf`.`nome`;

--
-- Definition of view `clientespj`
--

DROP TABLE IF EXISTS `clientespj`;
DROP VIEW IF EXISTS `clientespj`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `clientespj` AS select `cli`.`id` AS `id`,`pj`.`razaosocial` AS `razaosocial`,`pj`.`nomefantasia` AS `nomefantasia`,`pj`.`ie` AS `ie`,`pj`.`cnpj` AS `cnpj`,`cli`.`cep` AS `cep`,`cli`.`logradouro` AS `logradouro`,`cli`.`numero` AS `numero`,`cli`.`bairro` AS `bairro`,`cli`.`cidade` AS `cidade`,`cli`.`estado` AS `estado`,`cli`.`email` AS `email`,`cli`.`telefone1` AS `telefone1`,`cli`.`ramal1` AS `ramal1`,`cli`.`telefone2` AS `telefone2`,`cli`.`ramal2` AS `ramal2`,`cli`.`obs` AS `obs`,`cli`.`c_status` AS `c_status` from (`clientes` `cli` join `pessoajuridica` `pj` on((`cli`.`PessoaJuridica_cnpj` = `pj`.`cnpj`))) order by `pj`.`razaosocial`;

--
-- Definition of view `funcaofunc`
--

DROP TABLE IF EXISTS `funcaofunc`;
DROP VIEW IF EXISTS `funcaofunc`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `funcaofunc` AS select `m`.`id` AS `idFunc`,`m`.`nome` AS `nomeFunc`,`f`.`descricao` AS `funcao` from (`mecanico` `m` join `funcao` `f`) where ((`m`.`idFuncao` = `f`.`id`) and (`f`.`descricao` = _latin1'MECANICO'));



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
