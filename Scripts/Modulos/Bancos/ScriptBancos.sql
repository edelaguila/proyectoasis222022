CREATE TABLE IF NOT EXISTS `Bancos`.`Tbl_bancos` (
  Pk_idbancos INT NOT NULL,
  nombreBanco VARCHAR(25) NULL,
  direccion VARCHAR(45) NULL,
  contacto VARCHAR(45) NULL,
  PRIMARY KEY (`Pk_idbancos`)
  )ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `Bancos`.`Tbl_Reportes` (
  `Pk_idReportes` INT NOT NULL,
  `fechas` DATE NULL,
  `conceptoR` VARCHAR(45) NULL,
  `NombreR` VARCHAR(45) NULL,
  `ubicacion` VARCHAR(45) NULL,
  `BancoR` INT NULL,
  PRIMARY KEY (`Pk_idReportes`),
  CONSTRAINT `fkbanco`
    FOREIGN KEY (`BancoR`)
    REFERENCES `Bancos`.`Tbl_bancos` (`Pk_idbancos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
    )ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `Bancos`.`Tbl_Reg_tipoCambio` (
  `Pk_fecha` DATE NOT NULL,
  `compra` FLOAT NULL,
  `venta` FLOAT NULL,
  `Moneda` VARCHAR(20) NULL,
  `reporteCambio` INT NULL,
  PRIMARY KEY (`Pk_fecha`),
  CONSTRAINT `fkrepor`
    FOREIGN KEY (`reporteCambio`)
    REFERENCES `Bancos`.`Tbl_Reportes` (`Pk_idReportes`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
    )ENGINE=InnoDB DEFAULT CHARSET=utf8;
    
CREATE TABLE IF NOT EXISTS `Bancos`.`Tbl_Cuentas` (
  `Pk_idCuentas` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `estado_cta` VARCHAR(15) NOT NULL,
  `Saldos_cta` VARCHAR(45) NULL,
  PRIMARY KEY (`Pk_idCuentas`)
  )ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `Bancos`.`Tbl_tiposMov` (
  `Pk_idTipoMov` INT NOT NULL,
  `ConceptoTipo` VARCHAR(15) NULL,
  `DescripcionTipo` VARCHAR(45) NULL,
  PRIMARY KEY (`Pk_idTipoMov`)
  )ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `Bancos`.`Tbl_Movimientos` (
  `Pk_idMovimientos` INT NOT NULL,
  `tipo_mov` INT NULL,
  `fecha_reg` DATE NULL,
  `forma_pago` VARCHAR(20) NULL,
  `Cuenta_rela` INT NULL,
  `Monto` FLOAT NULL,
  `iva` FLOAT NULL,
  PRIMARY KEY (`Pk_idMovimientos`),
  CONSTRAINT `fktipo`
    FOREIGN KEY (`tipo_mov`)
    REFERENCES `Bancos`.`Tbl_tiposMov` (`Pk_idTipoMov`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fkcuentass`
    FOREIGN KEY (`Cuenta_rela`)
    REFERENCES `Bancos`.`Tbl_Cuentas` (`Pk_idCuentas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
    )ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `Bancos`.`Tbl_Ctrl_cheques` (
  `Pk_idControl_cheques` INT NOT NULL,
  `concepto` VARCHAR(45) NULL,
  `monto` INT NULL,
  `cta_beneficiaria` INT NULL,
  `fecha` DATE NULL,
  `Banco` INT NULL,
  PRIMARY KEY (`Pk_idControl_cheques`),
  CONSTRAINT `fkcuenta`
    FOREIGN KEY (`cta_beneficiaria`)
    REFERENCES `Bancos`.`Tbl_Cuentas` (`Pk_idCuentas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fkbancos`
    FOREIGN KEY (`Banco`)
    REFERENCES `Bancos`.`Tbl_bancos` (`Pk_idbancos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
    )ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `Bancos`.`Tbl_Conciliacion` (
  `Pk_idConciliacion` INT NOT NULL,
  `fecha_reg` DATE NULL,
  `descripcion` VARCHAR(45) NULL,
  `movimientos` INT NULL,
  PRIMARY KEY (`Pk_idConciliacion`),
  CONSTRAINT `fkmovi`
    FOREIGN KEY (`movimientos`)
    REFERENCES `Bancos`.`Tbl_Movimientos` (`Pk_idMovimientos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
    )ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `Bancos`.`Tbl_Disponibilidad` (
  Pk_idDispo INT NOT NULL,
  fecha_dispo DATE NULL,
  SaldoDispo FLOAT NULL,
  Comentario VARCHAR(45) NULL,
  cuentaDispo INT NULL,
  PRIMARY KEY (Pk_idDispo),
  CONSTRAINT fkcuenta
    FOREIGN KEY (cuentaDispo)
    REFERENCES `Bancos`.`Tbl_Cuentas` (Pk_idCuentas)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
    )ENGINE=InnoDB DEFAULT CHARSET=utf8;


