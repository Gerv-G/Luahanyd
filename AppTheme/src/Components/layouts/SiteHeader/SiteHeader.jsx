import React, { Component }from 'react'
import PropTypes from 'prop-types';

import { withStyles } from '@material-ui/core/styles';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import Typography from '@material-ui/core/Typography';
import IconButton from '@material-ui/core/IconButton'
import MenuItem from '@material-ui/core/MenuItem';
import MoreVertIcon from '@material-ui/icons/MoreVert';
import MenuIcon from '@material-ui/icons/Menu';

import HeaderStyles from './SiteHeaderStyles.js'
import { Menu } from '@material-ui/core';

const options = [
  'User Account Settings',
  'General Settings',
  'Logout'
];

class SiteHeader extends Component{
  state = {
    anchorEl: null,
  }
  
  handleClick = event => {
    this.setState({anchorEl: event.currentTarget});
  };

  handleClose = () => {
    this.setState({ anchorEl: null });
  }

  render(){
    const { anchorEl } = this.state;
    const open = Boolean(anchorEl);
    const { classes } = this.props;

    return(
      <div className={classes.root}>
        <AppBar position="absolute" color="primary">
          <Toolbar>
            <IconButton className={classes.menuButton}>
              <MenuIcon />
            </IconButton>
            <Typography className={classes.flex} variant="headline" color="inherit">
              Dynahaul Enterprises
            </Typography>
            <IconButton 
              color="inherit" 
              aria-label="More" 
              aria-owns={open ? 'long-menu' : null}
              aria-haspopup="true"
              onClick={this.handleClick}
            >
              <MoreVertIcon />
            </IconButton>
            <Menu
              id="long-menu"
              anchorEl={anchorEl}
              open={open}
              onClose={this.handleClose}
              PaperProps={{
                style: {
                  width: 200,
                },
              }}
            >
            {
              options.map(option => (
                  <MenuItem key={option} selected={option === 'None'} onClick={this.handleClose}>
                    {option}  
                  </MenuItem>  
                )
              )
            }
            </Menu>
          </Toolbar>
        </AppBar>
      </div>
    );
  }
}

SiteHeader.propTypes = {
  classes: PropTypes.object.isRequired,
};
  
export default withStyles(HeaderStyles)(SiteHeader);