package com.example.webshop.controllers;

import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("api/auth/")
public class AuthController {

	@PostMapping(value = "login")
	public ResponseEntity<Object> login() {
		Authentication auth = SecurityContextHolder.getContext().getAuthentication();
		String role = auth.getAuthorities().iterator().next().getAuthority();
		return new ResponseEntity<>("{\"role\":\"" + role + "\"}", HttpStatus.OK);
	}
}
