import React from "react";
import "./navbar.scss";

const Navbar = () => {
  return (
    <nav className="navbar">
      <ul className="nav-links">
        <li>
          <a href="/" className="nav-link active">
            City Tour
          </a>
        </li>
      </ul>
    </nav>
  );
};

export default Navbar;
