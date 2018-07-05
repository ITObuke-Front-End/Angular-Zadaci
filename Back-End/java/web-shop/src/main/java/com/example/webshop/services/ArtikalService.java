package com.example.webshop.services;

import java.util.List;
import java.util.Optional;
import java.util.stream.Collectors;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.webshop.models.Artikal;
import com.example.webshop.models.TipArtikla;
import com.example.webshop.models.dto.ArtikalDTO;
import com.example.webshop.repositories.ArtikalRepository;
import com.example.webshop.repositories.TipArtiklaRepository;

@Service
public class ArtikalService {

	private ArtikalRepository artikalRepository;
	private TipArtiklaRepository tipArtiklaRepository;

	@Autowired
	public ArtikalService(ArtikalRepository artikalRepository, TipArtiklaRepository tipArtiklaRepository) {
		super();
		this.artikalRepository = artikalRepository;
		this.tipArtiklaRepository = tipArtiklaRepository;
	}

	public ArtikalDTO save(ArtikalDTO artikalDTO) {
		TipArtikla tipArtikla = tipArtiklaRepository.findByNaziv(artikalDTO.getTipArtikla());
		Artikal artikal = artikalDTO.convert();
		artikal.setTipArtikla(tipArtikla);

		return new ArtikalDTO(artikalRepository.save(artikal));
	}

	public ArtikalDTO update(ArtikalDTO artikalDTO) {
		if (!artikalRepository.findById(artikalDTO.getId()).isPresent()) {
			return null;
		}

		TipArtikla tipArtikla = tipArtiklaRepository.findByNaziv(artikalDTO.getTipArtikla());
		Artikal artikal = artikalDTO.convert();
		artikal.setId(artikalDTO.getId());
		artikal.setTipArtikla(tipArtikla);

		return new ArtikalDTO(artikalRepository.save(artikal));
	}

	public List<ArtikalDTO> findAll() {
		return ((List<Artikal>) artikalRepository.findAll()).stream().map(artikal -> new ArtikalDTO(artikal))
				.collect(Collectors.toList());
	}

	public ArtikalDTO delete(Long id) {
		Optional<Artikal> artikal = artikalRepository.findById(id);

		if (artikal.isPresent()) {
			artikalRepository.deleteById(id);
			return new ArtikalDTO(artikal.get());
		}

		return null;
	}

	public ArtikalDTO findOne(Long id) {
		Optional<Artikal> artikal = artikalRepository.findById(id);
		return artikal.isPresent() ? new ArtikalDTO(artikal.get()) : null;
	}

	public List<ArtikalDTO> findByNaziv(String naziv) {
		return artikalRepository.searchByNaziv(naziv).stream().map(artikal -> new ArtikalDTO(artikal))
				.collect(Collectors.toList());
	}

}
