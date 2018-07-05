package com.example.webshop.repositories;

import org.springframework.data.repository.CrudRepository;

import com.example.webshop.models.TipArtikla;

public interface TipArtiklaRepository extends CrudRepository<TipArtikla, Long> {

	TipArtikla findByNaziv(String tipArtikla);

}
