package com.example.webshop.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.webshop.models.TipArtikla;
import com.example.webshop.repositories.TipArtiklaRepository;

@Service
public class TipArtiklaService {

	private TipArtiklaRepository repository;

	@Autowired
	public TipArtiklaService(TipArtiklaRepository repository) {
		super();
		this.repository = repository;
	}

	public List<TipArtikla> findAll() {
		return (List<TipArtikla>) repository.findAll();
	}

	public TipArtikla save(TipArtikla tipArtikla) {
		tipArtikla.setId(null);
		return repository.save(tipArtikla);
	}

	public TipArtikla update(TipArtikla tipArtikla) {
		if (!repository.findById(tipArtikla.getId()).isPresent()) {
			return null;
		}
		
		return repository.save(tipArtikla);
	}

	public TipArtikla delete(long id) {
		Optional<TipArtikla> artikal = repository.findById(id);

		if (artikal.isPresent()) {
			repository.deleteById(id);
			return artikal.get();
		}

		return null;
	}

	public TipArtikla findOne(Long id) {
		Optional<TipArtikla> tipArtikla = repository.findById(id);
		return tipArtikla.isPresent() ? tipArtikla.get() : null;
	}

}
