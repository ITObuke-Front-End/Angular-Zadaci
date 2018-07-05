package com.example.webshop.repositories;

import java.util.List;

import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;

import com.example.webshop.models.Artikal;

public interface ArtikalRepository extends CrudRepository<Artikal, Long> {

	@Query("SELECT a FROM Artikal a where lower(a.naziv) like lower(concat('%', :naziv,'%'))")
	List<Artikal> searchByNaziv(String naziv);
	
}
