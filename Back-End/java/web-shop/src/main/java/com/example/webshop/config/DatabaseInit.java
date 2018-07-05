package com.example.webshop.config;

import java.util.List;

import javax.annotation.PostConstruct;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import com.example.webshop.models.TipArtikla;
import com.example.webshop.models.dto.ArtikalDTO;
import com.example.webshop.repositories.TipArtiklaRepository;
import com.example.webshop.services.ArtikalService;

@Component
public class DatabaseInit {

	private TipArtiklaRepository tipArtiklaRepository;

	private ArtikalService artikalService;

	@Autowired
	public DatabaseInit(TipArtiklaRepository tipArtiklaRepository, ArtikalService artikalService) {
		super();
		this.tipArtiklaRepository = tipArtiklaRepository;
		this.artikalService = artikalService;
	}

	@PostConstruct
	public void init() {
		tipoviInit();
		artikliInit();
	}

	private void tipoviInit() {
		if (((List<TipArtikla>) tipArtiklaRepository.findAll()).isEmpty()) {
			tipArtiklaRepository.save(new TipArtikla(null, "Konzola", "Konzola za igru"));
			tipArtiklaRepository.save(new TipArtikla(null, "Igrica", "Racunarska igrica"));
			tipArtiklaRepository.save(new TipArtikla(null, "Dodaci za konzole", "Dodaci za konzole za igru"));
			tipArtiklaRepository.save(new TipArtikla(null, "Periferija", "Periferni uredjaj"));
		}
	}

	private void artikliInit() {
		if ((artikalService.findAll()).isEmpty()) {
			artikalService.save(new ArtikalDTO(1L, "257FRET3", "Nintendo Switch", 319.99,
					"Nintendo Switch is designed to go wherever you do, transforming from home console to portable system in a snap.'\n"
							+ " So you get more time to play the games you love, however you like.",
					"nintendoSwitch.jpg", "Konzola"));
			artikalService.save(new ArtikalDTO(2L, "44F56D5T", "Super Mario Odysse", 58.99,
					"Explore incredible places far from the Mushroom Kingdom as you join Mario and'\n"
							+ " his new ally Cappy on a massive, globe-trotting 3D adventure. ",
					"SuperMarioOdyssey.jpg", "Igrica"));
			artikalService.save(new ArtikalDTO(3L, "2RS3TS4T", "The Legend of Zelda: Breath of the Wild", 55.85,
					"No kingdom. No memories. After a 100-year slumber, Link wakes up alone in a world he no longer remembers.' +\n"
							+ " Now the legendary hero must explore a vast and dangerous land...",
					"Zelda.jpg", "Igrica"));
			artikalService.save(new ArtikalDTO(4L, "9F3VCS31", "Playstation 4", 399.99,
					"INCREDIBLE GAMES. ENDLESS ENTERTAINMENT", "playstation4.jpg", "Konzola"));
			artikalService.save(new ArtikalDTO(5L, "89FFCXS1", "Grand Theft Auto V", -1.,
					"A place for reality TV stars, paparazziand faith healers - see for yourself...", "gtaV.jpg",
					"Igrica"));
			artikalService.save(new ArtikalDTO(6L, "9DV3DZQZ", "DUALSHOCK 4 wireless controller", -1., "", "",
					"Dodaci za konzole"));
			artikalService.save(new ArtikalDTO(7L, "8DXL12D4", "Joy-Con", 50.99,
					"Add a splash of style to your Nintendo Switch console with Joy-Con controllers and Joy-Con straps.",
					"nintendoJoyCon.jpg", "Dodaci za konzole"));
		}
	}

}
