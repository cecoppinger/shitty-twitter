import Vue from 'vue';
import Router from 'vue-router';

import HomePage from '../components/HomePage.vue';
import ShittyTweet from '../components/ShittyTweet.vue';

Vue.use(Router);

export default new Router({
  mode: 'history',
  routes: [{
    name: 'HomePage',
    path: '/',
    component: HomePage,
  }, {
    name: 'ShittyTweet',
    path: '/shittytweet',
    component: ShittyTweet,
  }],
});
